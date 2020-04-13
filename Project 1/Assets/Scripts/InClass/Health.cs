using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Health : MonoBehaviour
{
   public int healthValue = 10;
   public AudioClip sound;

   private void OnTriggerEnter(Collider other)
   {
      healthValue--;
      if (healthValue > 0)
         return;

      //sound.Play;
         Destroy(gameObject);
   }
}
