using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public float sphereRadius = 5f;                         
    public LayerMask layerMask;                             
    public string playerObjectName1 = "PlayerCharacter1(Clone)";
    public string playerObjectName2 = "PlayerCharacter2(Clone)";
    public Color sphereColor = new Color(1, 0, 0, 0.2f);    

    void Update()
    {
        Vector3 center = transform.position;     

        Collider[] hitColliders = Physics.OverlapSphere(center, sphereRadius, layerMask); 

        foreach (var hitCollider in hitColliders)                     
        {
            if (hitCollider.gameObject.name == playerObjectName1)       
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
