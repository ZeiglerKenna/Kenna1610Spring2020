using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectableList : ScriptableObject
{
   
   public List<Collectable> collectables;
   public string singleWeapon;

   public void AddToList(Collectable weaponsObj)
   {
      collectables.Add(weaponsObj);
   }

   public void RemoveFromList (Collectable weaponsObj)
   {
      for (int i = 0; i < collectables.Count; i++)
      {
         if (collectables[i] == weaponsObj)
         {
            collectables.Remove(weaponsObj);
         }
      }
   }
   
}
