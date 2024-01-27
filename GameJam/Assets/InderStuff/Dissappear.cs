using UnityEngine;

public class RemoveOnTouch : MonoBehaviour
{
    private Vector3 originalScale;
    private Spawner_script spawnerScript;
    public  GameObject yourGameObjectReference;

    

    
    
    

    void Start()
    {
        originalScale = transform.localScale;
    }

    void OnMouseDown()
    {
        // Remove the object when mouse is pressed
        Destroy(gameObject);
        // Reference to the Spawner_script
        yourGameObjectReference = GameObject.Find("Spawner_script");

        spawnerScript.position = false;
       
        
    }

    void OnMouseUp()
    {
        // Restore the object when mouse button is released
        Instantiate(gameObject, transform.position, transform.rotation);
    }
   
}

