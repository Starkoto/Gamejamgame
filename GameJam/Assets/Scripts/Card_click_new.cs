using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
    void OnMouseDown()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Call a method to handle the destruction
            DestroyObjectOnClick();


        }




    }

    void DestroyObjectOnClick()
    {
        // Destroy the local GameObject (the one this script is attached to)
        Destroy(gameObject);
    }
}