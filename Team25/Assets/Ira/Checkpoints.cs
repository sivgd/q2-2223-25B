using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public int currentSpawnPoint = 0;
    public Transform[] Checkpointss;
    public GameObject player;
    // Start is called before the first frame update
    public void respawn()
    {
        player.transform.position = Checkpointss[currentSpawnPoint].position;
    }
}
