using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject[] objectsToActivate;
    

    
    private void Start()
    {
        foreach (GameObject obj in objectsToActivate)
        {
        //    obj.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag==("P1"))
        //{
            Debug.Log("enter");

            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
       // }
    }

    void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.tag==("P1"))
        //{
            Debug.Log("exit");

            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(false);
            }

            
        //}
    }

}