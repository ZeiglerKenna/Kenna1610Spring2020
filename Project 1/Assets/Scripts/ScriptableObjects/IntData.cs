using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
   public int value = 1;

   public void ChangeValue(int number)
   {
      value += number;
   }

   public void SetValue(int number)
   {
      value = number;
   }
}
