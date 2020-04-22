using UnityEngine;
using UnityEngine.Events;

public class Controller : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 30f;
    private int jumpCount = 0;
    public IntData jumpCountMax;
    public UnityEvent jumpEvent;
        
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }

        positionDirection.x = Input.GetAxis("Horizontal") * speed;

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax.value)
        {
            jumpEvent.Invoke();
            positionDirection.y = jumpForce;
            jumpCount++;
        }

        positionDirection.y -= gravity;
        controller.Move(positionDirection * Time.deltaTime);
    }
}
