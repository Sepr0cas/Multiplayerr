using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject arrow;
    public GameObject checkpoint1;
    public GameObject checkpoint2;
    public float speed = 2f;

    private Vector3 targetPosition;
    private bool movingToCheckpoint1 = true;

    void Start()
    {
        targetPosition = checkpoint1.transform.position;
    }

    public void move()
    {
       
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
           
            movingToCheckpoint1 = !movingToCheckpoint1;

            
            targetPosition = movingToCheckpoint1 ? checkpoint1.transform.position : checkpoint2.transform.position;

           
        }
    }
    public void Reset()
    {
        arrow.gameObject.transform.position = new Vector3(6.94f, 8.49f, 22.6f);
    }
}