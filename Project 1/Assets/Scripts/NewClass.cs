using System;
using UnityEngine;
using UnityEngine.Events;

public class NewClass : MonoBehaviour
{
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    public int scoreValue;
    public float floatNumber;
    public UnityEvent uEvent;
    public GameObject sphere1;
    public Animation sphere1Animation;
    public string capsule;
    public UnityEvent uAction;
    public Graphics uAsset;

    // Start is called before the first frame update
    private void Start()
    {
        print(nameString);
        print(intNum);
        print(floatNum);
        print(gameObj);
        print(sphere1);
        print(scoreValue);
        print(floatNumber);
        uEvent.Invoke();
        print(sphere1Animation);
        print(capsule);
        if (Input.GetKeyDown(KeyCode.C))
            GetComponent<Renderer> ().material.color = Color.cyan;
        // Unity Tutorial: https://learn.unity.com/tutorial/scripts-as-behaviour-components?projectId=5c8920b4edbc2a113b6bc26a#5c8924ededbc2a113b6bc373
        uAction.Invoke();
        print(uAsset);
    }

    // Update is called once per frame
    void Update()
    {
      
        {
           
        }
        
    }
}
