using UnityEngine;

public class HwControllerPractice : MonoBehaviour
{

    public CharacterController charControl;
    private Vector3 characterPos;
    public float speed = 30f;
    public float jumpForce = 20f;
    public float gravity = 10f;

    void Update()
    {
        charControl.Move(characterPos * Time.deltaTime);
        characterPos.x = Input.GetAxis("Vertical") * speed;
        characterPos.y -= gravity;

        if (Input.GetButtonDown("Jump") && charControl.isGrounded)
        {
            characterPos.y = jumpForce;
        }
        
    }
}
