 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMove : MonoBehaviour
{
    public float accel;
    public float superaccel;
    public float jumpStrength;//500
    public float superJumpStrength;//1000
    public bool grounded;
    public bool fast;
    private float currentaccel;
    private float currentJumpStrength;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    Animator a;
    AudioSource steps;
    private bool isplaying;
    public GameObject frognoiseholder;
    AudioSource frognoises;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        a = GetComponent<Animator>();
        steps = GetComponent<AudioSource>();
        frognoises = frognoiseholder.GetComponent<AudioSource>();
    }
    private void Update()
    {
        a.SetFloat("YVelocity", rb2.velocity.y);
        a.SetBool("Ground", grounded);

        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            rb2.AddForce(new Vector2(0, currentJumpStrength * transform.localScale.x));
            frognoises.Play();
        }
    }
    private void FixedUpdate()
    {

        float horizValue = Input.GetAxis("Horizontal");

        if(horizValue == 0)
        {
            a.SetBool("Moving", false);
            if (isplaying == true)
            {
                steps.Stop();
                isplaying = false;
            }
        }
        else
        {
            a.SetBool("Moving", true);
            if (isplaying == false && grounded == true)
            {
                steps.Play();
                isplaying = true;
            }

        }
        if (grounded == false && isplaying == true)
        {
            steps.Stop();
            isplaying = false;
        }

        rb2.AddForce(new Vector2(horizValue * currentaccel, 0));

        //Move right
        if(horizValue < 0)
        {
            sr.flipX = true;
        }
        else if(horizValue > 0)
        {
            sr.flipX = false;
        }



    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "SuperJump")
        {
            currentJumpStrength = superJumpStrength;
        }
        else
        {
            currentJumpStrength = jumpStrength;
        }
        if (fast == true)
        {
            currentaccel = superaccel;
        }
        else
        {
            currentaccel = accel;
        }
    }
}
