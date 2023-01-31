using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public bool collided = false;
    private Collider2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //collided = rb2.IsTouchingLayers();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player collided with me...");
            collided = true;
        }
    }
}
