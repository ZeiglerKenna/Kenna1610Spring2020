using UnityEngine;

public class EmemyMovesOnScriptedPath : MonoBehaviour
{
    public bool startPosition;
    public bool posB;
    public bool posC;

    void Update()
    {

        if (transform.position.z >= 4.7)
        {
            startPosition = true;
        }
        
        if (transform.position.z <= -9.7)
        {
            posB = true;
        }
        
        if (transform.position.x <= 9)
        {
            posC = true;
        }

        if (posB)
        {
            startPosition = false;
        }

        if (posC)
        {
            startPosition = false;
        }

        if (startPosition)
        {
            transform.Translate(Vector3.forward);
        }

        if (posB)
        {
            transform.Translate(Vector3.right);
        }

        if (posC)
        {
            transform.Translate(Vector3.left);
        }

    }
    
}
