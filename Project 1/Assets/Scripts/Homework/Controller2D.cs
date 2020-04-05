using UnityEngine;

public class Controller2D : MonoBehaviour
{
    public CharacterController2D controller2D;
    private Vector3 positionDirection;
    public float speed = 40f;
    public float gravity = 0f;
    public float jumpForce = 40f;
    public Animator animator;
    
    void Update()
    {
        animator.SetFloat("Walk", Mathf.Abs(speed));
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
    }
}
