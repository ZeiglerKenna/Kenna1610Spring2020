using UnityEngine;

public class Controller : MonoBehaviour
{

    public CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 0f;
    public float gravity = -3f;
    public float jumpForce = 10f;
    public Animator animator;
    
    void Update()
    {
        animator.SetFloat("Walk", Mathf.Abs(speed));
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
        }
        positionDirection.y += -gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
}
