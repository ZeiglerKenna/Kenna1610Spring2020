using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DamageAnimation : MonoBehaviour
{
    public float seconds = 1f;
    private WaitForSeconds waitObj;
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