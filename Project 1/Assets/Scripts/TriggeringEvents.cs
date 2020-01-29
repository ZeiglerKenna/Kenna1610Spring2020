using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int intOne;
    public float floatOne;
    public string stringOne;
    public UnityEvent uEventEnterOne;
    public UnityEvent uEventExitOne;
    public UnityEvent uEventStayOne;
    private void OnTriggerEnter(Collider other)
    {
        print(intOne);
        uEventEnterOne.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
       print(floatOne);
       uEventExitOne.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
       uEventStayOne.Invoke();
    }
}
