using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 100f;
    public GameObject player;
    float m_xRotate = 0.0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        m_xRotate -= mouseY;
        m_xRotate = Mathf.Clamp(m_xRotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(m_xRotate, 0.0f, 0.0f);
        player.transform.Rotate(Vector3.up, mouseX);
    }
}

