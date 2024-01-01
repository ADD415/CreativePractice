using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float rotationAngle = 90f; // Adjust the rotation angle as needed

    private bool isOpen = false;

    public void RotateDoor()
    {
        if (!isOpen)
        {
            // Rotate the door to the open position
            transform.Rotate(Vector3.up, rotationAngle);

            // Set the flag indicating that the door is open
            isOpen = true;
        }
        else
        {
            // Rotate the door back to the closed position
            transform.Rotate(Vector3.up, -rotationAngle);

            // Set the flag indicating that the door is closed
            isOpen = false;
        }

        Debug.Log("RotateDoor() called");

        // Print current rotation
        Debug.Log("Current Rotation: " + transform.rotation.eulerAngles);

        // Rotate the door
        transform.Rotate(Vector3.up, rotationAngle);

        // Print new rotation
        Debug.Log("New Rotation: " + transform.rotation.eulerAngles);
    }
}
