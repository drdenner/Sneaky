using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float mouseSensitivity = 2.0f;
    public float speed = 10.0f;
    public Camera camera;

    private void FixedUpdate()
    {
        rotate();
        move();
    }

    private void rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        gameObject.transform.Rotate(0, mouseX * mouseSensitivity, 0);
        float mouseY = Input.GetAxis("Mouse Y");
        camera.transform.Rotate(-mouseY * mouseSensitivity, 0, 0);
    }

    private void move()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        gameObject.transform.Translate(Vector3.forward * translation * Time.deltaTime);
        float rotation = Input.GetAxis("Horizontal") * speed;
        gameObject.transform.Translate(Vector3.right * rotation * Time.deltaTime);
    }
}
