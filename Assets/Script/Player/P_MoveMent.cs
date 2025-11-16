using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_MoveMent : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    public CharacterController playercon;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveAmount = transform.right * x + transform.forward * z;

        playercon.Move(moveAmount * speed * Time.deltaTime);
    }
}
