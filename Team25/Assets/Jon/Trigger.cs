using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
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
        LayerMask mask = LayerMask.GetMask("Default");
        collided = rb2.IsTouchingLayers(mask);
    }
}
