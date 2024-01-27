using UnityEngine;

public class ScaleOnHover : MonoBehaviour
{
    public Vector3 customScale = new Vector3(0.4f, 0.5f, 1f); // Set the custom scale for hover

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void OnMouseEnter()
    {
        // Scale up with the custom size when mouse enters
        transform.localScale = customScale;
    }

    void OnMouseExit()
    {
        // Reset to original scale when mouse exits
        transform.localScale = originalScale;
    }
}
