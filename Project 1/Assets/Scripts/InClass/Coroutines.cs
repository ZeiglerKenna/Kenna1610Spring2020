﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public int counter = 3;
    public float seconds = 1f;
    public IntData numberData;

    public UnityEvent startEvent, repeatEvent, endEvent, postEndEvent;
    IEnumerator Start()
    {
        startEvent.Invoke();

        while (counter > 0)
        {
            numberData.value = counter;
            yield return new WaitForSeconds(seconds);
            repeatEvent.Invoke();
            counter--;
        }
        yield return new WaitForSeconds(seconds);
        endEvent.Invoke();
        yield return new WaitForSeconds(seconds);
        postEndEvent.Invoke();
    }
}