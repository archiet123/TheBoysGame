using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float Movement;

    public Trasnform MoveSpeed;

    float HorizontalInput;
    float VerticalInput;
    Vector3 MoveDirection;

    Ridgidbody rb;

    private void Start()
    {
        rb = GetComponent<Ridgidbody>();
        rb.freezeRotaion = true;
    }

    private void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput()
    {
        HorizontalInput.Input.GetAxisRaw("Horizontal");
        VerticalInput.Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //calculate movement direction
        MoveDirection = orientation.forward * VerticalInput + orientation.right * HorizontalInput;

        rb.AddForce(MoveDirection.normalized * MoveSpeed * 10f, ForceMode.Force);
    }

}
