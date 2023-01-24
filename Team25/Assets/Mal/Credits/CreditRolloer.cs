using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRolloer : MonoBehaviour
{
    private static int nScreens = 6;
    private GameObject[] creditScenes = new GameObject[nScreens];
    private static int swapCount;
    
    // Start is called before the first frame update
    void Start()
    {
        //For each credit scene, add a reference here
        //creditScenes[0] = GameObject.find("Credit1"); - needs fixing
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
