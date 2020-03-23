using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
       
    private void OnTriggerEnter(Collider other)
    {
      triggerEnterEvent.Invoke();
    }

    public UnityEvent triggerExitEvent;

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }

    public UnityEvent triggerStayEvent;

    private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }

    public UnityEvent triggerEnterEventTwo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerEnterEventTwo.Invoke();
    }

    public UnityEvent triggerExitEventTwo;

    private void OnTriggerExit2D(Collider2D other)
    {
        triggerExitEventTwo.Invoke();
    }

    public UnityEvent triggerStayEventTwo;

    private void OnTriggerStay2D(Collider2D other)
    {
        triggerStayEventTwo.Invoke();
    }
}