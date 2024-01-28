using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
    // Called when the object is clicked
    void OnMouseDown()
    {
        // Destroy the object when clicked
        Destroy(gameObject);
    }
}

