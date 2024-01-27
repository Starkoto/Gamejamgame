using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public Vector2 targetPosition = new Vector2(5f, 3f);
    public float moveSpeed = 2f;

    void Update()
    {
        MoveToTargetPosition();
    }

    void MoveToTargetPosition()
    {
        // Calculate the new position using Vector2.Lerp
        Vector2 newPosition = Vector2.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // Update the object's position
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }
}
