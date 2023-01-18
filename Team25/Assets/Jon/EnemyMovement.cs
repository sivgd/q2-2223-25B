using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float accel = 8;
    //public GameObject mainPlayer;
    private Rigidbody2D rb2;

    public GameObject TF;
    public GameObject TBF;
    public GameObject TB;
    public bool TFtrigger, TBFtrigger, TBtrigger;
    public bool AvoidEdge;



    //private Vector2 playerPosition;

    //public bool playerOnLeft;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //GetComponent is called every update, otherwise the info would be outdated
        TFtrigger = TF.GetComponent<Trigger>().collided;
        TBFtrigger = TBF.GetComponent<Trigger>().collided;
        TBtrigger = TB.GetComponent<Trigger>().collided;


        //Debug.Log(TLtrigger + " " + TRtrigger);

        if (TFtrigger == true)
        {
            transform.Rotate(0, 180, 0, Space.Self);
            rb2.velocity = new Vector2(0, 0);
        }

        if (AvoidEdge == true && TBtrigger == true && TBFtrigger != true)
        {
            transform.Rotate(0, 180, 0, Space.Self);
            //still prevents the enemy from falling off cliff due to too much speed
            rb2.velocity = new Vector2(0, 0);
        }
        //movement direction depends entirely on rotation
        if (transform.rotation.y == -1)
        {
            rb2.AddForce(new Vector2(-accel, 0));
        }
        else
        {
            rb2.AddForce(new Vector2(accel, 0));
        }

    }
}
