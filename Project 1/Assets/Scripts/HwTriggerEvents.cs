using System;
using UnityEngine;
using UnityEngine.Events;

public class HwTriggerEvents : MonoBehaviour
{
   public int uEventInt;
   public float uEventFloat;
   public UnityEvent uEventEnter, uEventExit, uEventStay;
   public UnityEvent uEventMouseDown, uEventMouseUp, uEventMouseEnter, uEventMouseExit;

   private void OnTriggerEnter(Collider other)
   {
      print(uEventInt);
      uEventEnter.Invoke();
   }

   private void OnTriggerExit(Collider other)
   {
      print(uEventFloat);
      uEventExit.Invoke();
   }

   private void OnTriggerStay(Collider other)
   {
      uEventStay.Invoke();
   }

   private void OnMouseDown()
   {
      uEventMouseDown.Invoke();
   }

   private void OnMouseUp()
   {
      uEventMouseUp.Invoke();
   }

   private void OnMouseEnter()
   {
      uEventMouseEnter.Invoke();
   }

   private void OnMouseExit()
   {
      uEventMouseExit.Invoke();
   }
}
