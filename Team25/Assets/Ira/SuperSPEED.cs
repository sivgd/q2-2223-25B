using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSPEED : MonoBehaviour
{

    public float multiplier = 1f;


    public GameObject pickupEffect;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        player.transform.localScale *= multiplier;

        Destroy(gameObject);
    }
}
