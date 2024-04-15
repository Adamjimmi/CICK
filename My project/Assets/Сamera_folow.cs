using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the object the camera should follow
    public float followSpeed = 5f; // Speed of camera movement
    public Vector3 offset; // Offset of the camera relative to the target

    private void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the new camera position
            Vector3 desiredPosition = target.position + offset;

            // Move the camera towards the desired position
            transform.position = Vector3.MoveTowards(transform.position, desiredPosition, followSpeed * Time.deltaTime);
        }
    }
}