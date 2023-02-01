using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSPEED : MonoBehaviour
{

    public float multiplier = 1f;
    public float duration = 4f;

    public GameObject pickupEffect;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        playerSTATS stats = player.GetComponent<playerSTATS>();
        stats.health *= multiplier;

        GetComponent<PolygonCollider2D>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(2);

        stats.health /= multiplier;

        Destroy(gameObject);
    }
}
