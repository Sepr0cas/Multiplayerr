using Unity.VisualScripting;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject puzzleactivate;
    public GameObject P2puzzleactivate;
    

    
    private void Start()
    {
        puzzleactivate.SetActive(false);
        P2puzzleactivate.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "P1")
        {
            puzzleactivate.SetActive(true);
            Debug.Log("P1 activate");
        }
        if (other.gameObject.tag == "P2")
        {
            P2puzzleactivate.SetActive(true);
            Debug.Log("P2 activate");
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "P1")
        {
            puzzleactivate.SetActive(false);
            Debug.Log("P1 DEactivate");
        }
        if (other.gameObject.tag == "P2")
        {
            P2puzzleactivate.SetActive(false);
            Debug.Log("P2 activate");
        }
    }

}