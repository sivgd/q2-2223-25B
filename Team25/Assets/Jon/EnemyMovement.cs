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
    public GameObject TBL;
    public GameObject TBR;
    public GameObject TB;
    public GameObject SR;
    public bool TLtrigger, TRtrigger, TBLtrigger, TBRtrigger, TBtrigger;
    


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
        TLtrigger = TL.GetComponent<Trigger>().collided;
        TRtrigger = TR.GetComponent<Trigger>().collided;
        TBLtrigger = TBL.GetComponent<Trigger>().collided;
        TBRtrigger = TBR.GetComponent<Trigger>().collided;
        TBtrigger = TB.GetComponent<Trigger>().collided;
        //Debug.Log(TLtrigger + " " + TRtrigger);
        if ((TLtrigger == true) ^ (TRtrigger == true))
        {
            //Debug.Log(TLtrigger + " " + TRtrigger);
            if (TLtrigger == true)
            {
                MoveLeft = false;
            }
            if (TRtrigger == true)
            {
                MoveLeft = true;
            }
        }
        if (TBtrigger != true)
        {
            if (TBLtrigger != true)
            {
                MoveLeft = false;
            }
            if (TBRtrigger != true)
            {
                MoveLeft = true;
            }
        }
        if (MoveLeft == true)
        {
            SR.flipX = false;
            rb2.AddForce(new Vector2(-accel, 0));
        }
        else
        {
            SR.flipX = true;
            rb2.AddForce(new Vector2(accel, 0));
        }

    }
}
