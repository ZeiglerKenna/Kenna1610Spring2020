using UnityEngine;

public class HwIfStatements : MonoBehaviour
{
  public int a = 10;
  public int b = 10;
  public int c = 10;
  public string passCode = "P@S$W0R4";
  public bool canJump = true;
  
  void Start()
  {
    if (a + b <= c)
    {
      print("Big");
    }
    
    if (passCode != "P@S$W0R4")
    {
      print("Wrong Password!");
    }

    if (canJump)
    {
      print("Can Jump!");
    }
    
  }
  
} 
