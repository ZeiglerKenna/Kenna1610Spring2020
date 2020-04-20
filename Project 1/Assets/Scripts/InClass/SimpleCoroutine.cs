using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class SimpleCoroutine : MonoBehaviour
{
   private WaitForSeconds waitObj;
   public float seconds = 1f;
   public bool canRun { get; set; } = true;
   public UnityEvent repeatEvent;

   private void Awake()
   {
      waitObj = new WaitForSeconds(seconds);
   }

   public void Restart()
   {
      StartCoroutine(OnStartCoroutine());
   }

   public IEnumerator OnStartCoroutine()
   {
      canRun = true;
      while (canRun)
      {
         repeatEvent.Invoke();
         yield return waitObj;
      }
   }
}
