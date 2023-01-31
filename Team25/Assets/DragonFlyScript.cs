using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DragonFlyScript : MonoBehaviour
{
    private Collider2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player collided with me...");
            SceneManager.LoadScene("CreditScenes");
        }
    }
}
