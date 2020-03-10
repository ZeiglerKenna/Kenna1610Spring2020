using System.Collections;
using UnityEngine;

public class Countdown : MonoBehaviour
{

    public int countdownSeconds = 3;
    
    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        WaitForSeconds(3);
    }
    
    //Trying to figure out a countdown system using Coroutines referencing the Unity API for coroutines https://docs.unity3d.com/Manual/Coroutines.html
}
