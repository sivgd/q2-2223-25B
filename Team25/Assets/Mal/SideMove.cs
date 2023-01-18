 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMove : MonoBehaviour
{
    public float accel;
    public float superaccel;
    public bool superduperexpertaccelactive;
    private float currentaccel;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {


        if (superduperexpertaccelactive == true)
        {
            currentaccel = superaccel;
        }
        else
        {
            currentaccel = accel;
        }


        //Move right
        if(Input.GetAxis("Horizontal")> 0)
        {
            sr.flipX = false;
            rb2.AddForce(new Vector2(currentaccel, 0));
        }

        //Move left
        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
            rb2.AddForce(new Vector2(-currentaccel, 0));
        }



    }
}
