using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject targetCamera;
    public float movementSpeed = 2;
    public float cameraRotationX;
    public float cameraRotationY;
    public GameObject pivot;

    private float smoothFactor = 5f;

    private void Start()
    {
        cameraRotationX = pivot.transform.localRotation.eulerAngles.x;
        cameraRotationY = targetCamera.transform.localRotation.eulerAngles.y;
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Mouse X");
        float verticalInput = -Input.GetAxisRaw("Mouse Y");
        cameraRotationX += horizontalInput * Time.deltaTime * movementSpeed;
        cameraRotationY += verticalInput * Time.deltaTime * movementSpeed;

        // Smoothly interpolate camera rotation
        float smoothHorizontal = Mathf.LerpAngle(pivot.transform.localRotation.eulerAngles.y, cameraRotationX, Time.deltaTime * smoothFactor);
        float smoothVertical = Mathf.LerpAngle(targetCamera.transform.localRotation.eulerAngles.x, cameraRotationY, Time.deltaTime * smoothFactor);

        pivot.transform.localRotation = Quaternion.Euler(0, smoothHorizontal, 0);
        targetCamera.transform.localRotation = Quaternion.Euler(smoothVertical, 0, 0);
    }
}
