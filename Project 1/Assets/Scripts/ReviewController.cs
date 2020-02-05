using UnityEngine;

public class ReviewController : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 20f;
    public int jumpCountMax = 2;
    private static double jumpCount;
    void Start()
    {
        
    }
    
    void Update()
    {
        controller.Move(positionDirection*Time.deltaTime);
        positionDirection.x = Input.GetAxis("Vertical")*speed;
        positionDirection.z = Input.GetAxis("Horizontal") * -speed;
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
