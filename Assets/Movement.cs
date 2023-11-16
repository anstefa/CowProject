using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 15f; // Geschwindigkeit der Kamerabewegung

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Eingabe für horizontale Bewegung (A und D Tasten oder Pfeiltasten links/rechts)
        float verticalInput = Input.GetAxis("Vertical"); // Eingabe für vertikale Bewegung (W und S Tasten oder Pfeiltasten hoch/runter)

        // Bewegung der Kamera in horizontaler Richtung
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
