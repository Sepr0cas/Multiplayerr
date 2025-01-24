using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenmovingplatform : MonoBehaviour
{
    public MovingPlatform platform;
    public GameObject checkpoint;

    private void Start()
    {
        checkpoint.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        checkpoint.SetActive(true);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("P1") || other.CompareTag("P2"))
        {
            platform.move();

        }
        
    }
}