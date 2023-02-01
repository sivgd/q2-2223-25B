using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillLogo : MonoBehaviour
{
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Invoke("bye", 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void bye()
    {
        sr.enabled = false;
    }
}
