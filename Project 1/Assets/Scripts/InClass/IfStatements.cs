using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "OU812";
    public bool canRun = true;
    
    void Start()
    {
        if (a + b != c)
        {
            print("True");
        }

        if (password == "OU812")
        {
            print("Correct Password");
        }

        if (!canRun)
        {
            print("We can't run");
        }
    }
    
    void Update()
    {
        
    }
}
