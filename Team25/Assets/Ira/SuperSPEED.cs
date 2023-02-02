using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSPEED : MonoBehaviour
{

    public float speedmultiplier = 1f;
    public float duration = 4f;
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("FrOG");

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           StartCoroutine( Pickup(other) );
            player.GetComponent<SideMove>().speedboosttimer = 250;
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
      //  Instantiate(transform.position, transform.rotation);

        playerSTATS stats = player.GetComponent<playerSTATS>();
        stats.health *= speedmultiplier;

        GetComponent<PolygonCollider2D>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(2);

        stats.health /= speedmultiplier;

        Destroy(gameObject);
    }

    private void Instantiate(Vector3 position, Quaternion rotation)
    {
        throw new NotImplementedException();
    }
}
