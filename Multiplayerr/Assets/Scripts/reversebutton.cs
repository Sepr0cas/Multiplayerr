using Unity.VisualScripting;
using UnityEngine;

public class reversebutton : MonoBehaviour
{
    public GameObject puzzleactivate;
    



   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P1" || other.gameObject.tag == "P2")
        {
            puzzleactivate.SetActive(false);
            Debug.Log("P1 activate");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "P1" || other.gameObject.tag == "P2")
        {
            puzzleactivate.SetActive(true);
            Debug.Log("P1 DEactivate");
        }
        
    }

}