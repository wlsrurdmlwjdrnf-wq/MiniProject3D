using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;

    private Vector3 MoveDir;
    private CharacterController characterController;


    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        characterController.Move(MoveDir * moveSpeed * Time.deltaTime);
    }

    public void MoveTo(Vector3 dir)
    {
        MoveDir = dir;
    }
}
