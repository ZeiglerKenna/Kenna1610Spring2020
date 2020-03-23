using UnityEngine;

public class PracticeMoveAndDoubleJump : MonoBehaviour
{
    public CharacterController characterControl;
    public Vector3 pos;
    public float speed;
    public float gravity;
    public float jump;
    public int maxCount;
    private static double count;
    void Update()
    {
        characterControl.Move(pos * Time.deltaTime);
        pos.x = Input.GetAxis("Vertical") * speed;
        pos.z = Input.GetAxis("Horizontal") * -speed;
        pos.y -= gravity;

        if (characterControl.isGrounded)
        {
            pos.y = 0;
            count = 0;
        }

        if (Input.GetButtonDown("Jump") && count < maxCount)
        {
            pos.y = jump;
            count++;
        }
    }
}
