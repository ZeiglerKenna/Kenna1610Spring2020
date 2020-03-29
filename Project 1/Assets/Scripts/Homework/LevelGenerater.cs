using UnityEngine;
using UnityEngine.AI;

public class LevelGenerater: MonoBehaviour
{
   public int width = 10;
   public int height = 10;

   public GameObject wallObj;
   public GameObject playerAi;

   private bool playerAiSpawned = false;

   private void Start()
   {
      GenerateLevel();
   }

   void GenerateLevel()
   {
      for (int x = 0; x <= width; x += 2)
      {
         for (int y = 0; y <= height; y += 2)
         {
           if (Random.value > .7f)
            {
               Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
               Instantiate(wallObj, pos, Quaternion.identity, transform);
            } else if (!playerAiSpawned)
            {
               Vector3 pos = new Vector3(x - width / 2f, 1.25f, y - height / 2f);
               Instantiate(playerAi, pos, Quaternion.identity);
               playerAiSpawned = true;
            }
         }
      }
   }
}

//Used the second Brackeys Tutorial on Navmesh Pathfinders: https://www.youtube.com/watch?v=FkLJ45Pt-mY&list=PL41Evg_v_Nbas9qL1TJ3i_gifWhQr3Sfm&index=2&t=11s
//He shows the code for the random generation of levels and I thought it would be fun to try so I also typed that out along with what he teaches in this tutorial
//I actually believe that the new update of Unity got rid of some of the functions he uses in this tutorial, so I guess now this is just a level generation script
//Looks like even the level generation works differently now