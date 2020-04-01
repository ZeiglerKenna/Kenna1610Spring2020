using System.Collections;
using UnityEngine;

public class AlternateCoroutine : MonoBehaviour
{
   private WaitForFixedUpdate waitObj;
   public bool canRun = true;

   private void Start()
   {
      waitObj = new WaitForFixedUpdate();
      StartCoroutine(OnStartCoroutine());
   }

   public IEnumerator OnStartCoroutine()
   {
      while (canRun)
      {
         yield return waitObj;
         print("Repeating");
      }
   }
}
