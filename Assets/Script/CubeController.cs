using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float moveSpeed = 15f;  // Speed of the cube's movement

    void Update()
    {
        // Get input from keyboard
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down Arrow

        // Create a movement vector
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // Apply movement to the cube
        transform.Translate(movement, Space.World);
    }
}
