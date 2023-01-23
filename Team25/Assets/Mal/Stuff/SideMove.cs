 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMove : MonoBehaviour
{
    public float accel;
    public float superaccel;
    private float currentaccel;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    Animator a;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        a = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {

        float horizValue = Input.GetAxis("Horizontal");

        if(horizValue == 0)
        {
            a.SetBool("Moving", false);
        }
        else
        {
            a.SetBool("Moving", true);
        }

        rb2.AddForce(new Vector2(horizValue * currentaccel, 0));

        //Move right
        if(horizValue < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "SuperSpeed")
        {
            currentaccel = superaccel;
        }
        else
        {
            currentaccel = accel;
        }
    }
}
