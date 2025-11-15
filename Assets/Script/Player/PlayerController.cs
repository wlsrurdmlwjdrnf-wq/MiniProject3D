using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private MoveMent moveM;

    private void Awake()
    {
        moveM = GetComponent<MoveMent>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        moveM.MoveTo(new Vector3(x, 0.0f, z));        
    }
}