using UnityEngine;

public class TransformBehavior : MonoBehaviour
{
    public string otherTagString;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(otherTagString)) return;
        transform.parent = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}