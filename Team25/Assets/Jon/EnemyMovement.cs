using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float accel = 8;
    //public GameObject mainPlayer;
    private Rigidbody2D rb2;
    private bool MoveLeft = true;

    public GameObject TL;
    public GameObject TR;
    public bool TLtrigger, TRtrigger;
    


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
        TLtrigger = TL.GetComponent<TriggerLeft>().leftcollide;
        TRtrigger = TR.GetComponent<TriggerRight>().rightcollide;
        //Debug.Log(TLtrigger + " " + TRtrigger);
        if ((TLtrigger == true) ^ (TRtrigger == true))
        {
            Debug.Log(TLtrigger + " " + TRtrigger);
            if (TLtrigger == true)
            {
                MoveLeft = false;
            }
            if (TRtrigger == true)
            {
                MoveLeft = true;
            }
        }
        if (MoveLeft == true)
        {
            rb2.AddForce(new Vector2(-accel, 0));
        }
        else
        {
            rb2.AddForce(new Vector2(accel, 0));
        }

    }
}
