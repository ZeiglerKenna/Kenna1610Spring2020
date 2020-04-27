using System.Collections;
using UnityEngine;
using UnityEngine.Events;


public class PowerupAnimation : MonoBehaviour
{
    public float seconds = 1f;
    private WaitForSeconds waitObj;
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
        {
            repeatEvent.Invoke();
            yield return waitObj;
        }
    }
}