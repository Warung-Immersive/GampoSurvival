using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    // Public variables to set the offset from the main camera in the Inspector
    public float offsetX = 0.0f;
    public float offsetY = 0.0f;
    public float offsetZ = 0.0f;

    void Start()
    {
        // Get the main camera's position
        Vector3 cameraPosition = Camera.main.transform.position;

        // Calculate the new position based on the offsets
        Vector3 newPosition = new Vector3(
            cameraPosition.x + offsetX,
            cameraPosition.y + offsetY,
            cameraPosition.z + offsetZ
        );

        // Set the position of the game object
        transform.position = newPosition;
    }
}
