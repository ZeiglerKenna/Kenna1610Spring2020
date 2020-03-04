using UnityEngine;
using UnityEngine.Events;

public class MonoBehaviors : MonoBehaviour
{

    public UnityEvent startEvent;
    void Start()
    {
    startEvent.Invoke();
    }


}
