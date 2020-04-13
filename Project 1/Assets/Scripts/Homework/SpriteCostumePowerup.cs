using UnityEngine;
using UnityEngine.Events;

public class SpriteCostumePowerup : MonoBehaviour
{
  public GameObject purplePowerUp;
  public UnityEvent powerupEvent;
  
  void OnTriggerEnter(Collider other)
  {
    if (purplePowerUp)
    {
      powerupEvent.Invoke();
    }
  }
}
