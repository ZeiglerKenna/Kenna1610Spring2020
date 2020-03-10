using UnityEngine;

public class EmemyMovesOnScriptedPath : MonoBehaviour
{
    public bool startPosition;
    public bool endPosition;
   

    void Update()
    {

        if (transform.position.z >= 4.7)
        {
            startPosition = true;
        }

        if (transform.position.z <= -9.7)
        {
            startPosition = false;
        }

        if (startPosition)
        {
            transform.Translate(Vector3.back);
        }

        else
        {
            transform.Translate(Vector3.forward);
        }

    }
    
}
