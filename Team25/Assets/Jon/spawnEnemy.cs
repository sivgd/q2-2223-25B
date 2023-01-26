using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject T;
    public bool Trigger;
  //  private 
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        Trigger = T.GetComponent<Trigger>().collided;
        if (Trigger == true)
        {
            GameObject b = Instantiate(Enemy, transform.position, Quaternion.identity);
            this.enabled = false;
        }
    }
}
