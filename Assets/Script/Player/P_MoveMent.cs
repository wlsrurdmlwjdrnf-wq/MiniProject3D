using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_MoveMent : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumpHeight = 2.0f;
    public CharacterController playerController;
    public Transform groundCheck;
    public float radius = 0.03f;
    [SerializeField] private bool isGround;
    public LayerMask ground;
    Vector3 velocity;
    Vector3 gravityMovement;

    private void Update()
    {
        isGround = Physics.CheckSphere(groundCheck.position, radius, ground);

        if (isGround && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            velocity.y = Mathf.Sqrt(2.0f * 9.8f * jumpHeight);
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveAmount = transform.right * x + transform.forward * z;
        float magnitude = moveAmount.magnitude;
        if (magnitude > 1.0f)
        {
            magnitude = 1.0f;
        }
        moveAmount.Normalize();
        playerController.Move(moveAmount * magnitude * speed * Time.deltaTime);

        velocity.y += -9.8f * Time.deltaTime;
        gravityMovement.y = velocity.y * Time.deltaTime;
        playerController.Move(gravityMovement);
    }
}
