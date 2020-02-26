using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class ReviewController : MonoBehaviour
{
    private CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 20f;
    public int jumpCountMax = 2;
    private int jumpCount;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        controller.Move(positionDirection*Time.deltaTime);
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        positionDirection.z = Input.GetAxis("Vertical") * speed;
        positionDirection.y -= gravity;

        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }
        
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }
    }
}
