using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Button))]

public class Button : MonoBehaviour
{
   public Button uiButton;
   private object onClick;

   void Start()
    {
        Button btn = uiButton.GetComponent<Button>();
    }
    
    void OnMouseDown()
    {
        Debug.Log ("Congratulations!");
    }
    
    //https://docs.unity3d.com/530/Documentation/ScriptReference/UI.Button-onClick.html
    
}
