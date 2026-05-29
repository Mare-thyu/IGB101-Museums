using UnityEngine;

public class FlyCamera : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float lookSpeed = 2f;

    float rotationX = 0f;
    float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Mouse look
        rotationX += Input.GetAxis("Mouse X") * lookSpeed * 100f * Time.deltaTime;
        rotationY -= Input.GetAxis("Mouse Y") * lookSpeed * 100f * Time.deltaTime;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationY, rotationX, 0f);

        // Movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        transform.position += move * moveSpeed * Time.deltaTime;

        // Up/Down movement
        if (Input.GetKey(KeyCode.E))
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;

        // Unlock cursor
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}