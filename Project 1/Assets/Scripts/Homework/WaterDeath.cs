using UnityEngine;
using UnityEngine.Events;

public class WaterDeath : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public GameObject player;
       
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        FindObjectOfType<GameManager>().EndGame();
    }
}
