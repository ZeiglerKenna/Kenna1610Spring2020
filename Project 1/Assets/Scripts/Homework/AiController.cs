using UnityEngine;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{

   public Camera mainCamera;
   public NavMeshAgent agentAi;
   public float speed = 50f;
   
   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
        Ray pathfinderRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit positionHit;

        if (Physics.Raycast(pathfinderRay, out positionHit))
        {
            agentAi.SetDestination(positionHit.point);
        }
      }
   }
}

//Tried Brackeys tutorials on NavMeshes like we mentioned in class to practice. I used this video: https://www.youtube.com/watch?v=CHV1ymlw-P8
