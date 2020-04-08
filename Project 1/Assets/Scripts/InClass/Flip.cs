using UnityEngine;

public class Flip : MonoBehaviour
{

    public KeyCode key1 = KeyCode.LeftArrow, key2 = KeyCode.RightArrow;
    public float direction1 = 0, direction2 = 180;
    private Vector3 direction;
    
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, direction2, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0,direction1,0);
        }
    }

    public void FlipRotation(float value)
    {
        transform.Rotate(0, value, 0);
    }
}
