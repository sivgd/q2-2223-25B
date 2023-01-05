using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRight : MonoBehaviour
{
    public bool rightcollide = false;
    private Collider2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rightcollide = rb2.IsTouchingLayers();
    }
}
