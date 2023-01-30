using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class leaveCredits : MonoBehaviour
{
    public int delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        //if (delay > 0)
        //{
        delay -= 1;
        //}
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && (delay <= 0))
        {
            SceneManager.LoadScene("Menu");
        }
        if (delay <= -134950)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
