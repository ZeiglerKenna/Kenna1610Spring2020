using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    
    public UnityEvent onMouseDrag;
    
    private void OnMouseDrag()
    {
        onMouseDrag.Invoke();
    }

    public UnityEvent onMouseDown;
    
    private void OnMouseDown()
    {
        onMouseDown.Invoke();
        }
    
    public UnityEvent onMouseUp;
    
    private void OnMouseUp()
    {
        onMouseUp.Invoke();
            }

    public UnityEvent  onMouseEnter, onMouseExit;

    private void OnMouseEnter()
    {
        onMouseEnter.Invoke();
            }
    
    private void OnMouseExit()
    {
        onMouseExit.Invoke();
        }
}
