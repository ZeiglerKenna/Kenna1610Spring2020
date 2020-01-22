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
    


    // Start is called before the first frame update
    private void Start()
    {
        print(nameString);
        print(intNum);
        print(floatNum);
        print(gameObj);
        uEvent.Invoke();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
