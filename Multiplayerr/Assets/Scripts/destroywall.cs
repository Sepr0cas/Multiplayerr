using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywall : MonoBehaviour
{
    public GameObject bluewalls;
    public GameObject redwalls;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag==("P1") || other.gameObject.tag==("P2")){
            Destroy(bluewalls);
            Destroy(redwalls);
        }
    }
}
