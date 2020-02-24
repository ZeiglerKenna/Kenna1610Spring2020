using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
   public float value = 1;

   public void ChangeValue(int number)
   {
      value += number;
   }
}
