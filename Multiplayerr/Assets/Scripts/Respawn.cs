using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SearchService;

public class Respawn : MonoBehaviour
{
    public lastarrow lastarrow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("P1") || other.CompareTag("P2"))
        {
           
            CharacterController controller = other.GetComponent<CharacterController>();
            if (controller != null)
            {
                controller.enabled = false;
                other.gameObject.transform.position = new Vector3(0f, 3f, 0f);
                controller.enabled = true;
                lastarrow.Reset();
            }

            Debug.Log("respawn");
        }
    }
}

