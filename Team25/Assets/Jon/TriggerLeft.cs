using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLeft : MonoBehaviour
{
    public bool leftcollide = false;
    private Collider2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        leftcollide = rb2.IsTouchingLayers();
    }
}
