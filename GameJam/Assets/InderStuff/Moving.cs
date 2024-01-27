using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Vector2 targetPosition = new Vector2(5f,3f);
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    MoveObjectTowardsTarget();
    
       
    }

    void MoveObjectTowardsTarget()
    {
        // Calculate the distance between the current position and the target position
        float distance = Vector2.Distance(transform.position, targetPosition);

        // If the object is not at the target position, move towards it
        if (distance > 0.01f)
        {
            // Calculate the direction to the target position
            Vector2 direction = (targetPosition - (Vector2)transform.position).normalized;

            // Move the object towards the target position
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    
}