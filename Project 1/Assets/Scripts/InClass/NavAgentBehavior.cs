using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehavior : MonoBehaviour
{
   private NavMeshAgent agent;
   public Transform player;
   public float speed = 8f;
   
   private void Start()
   {
      agent = GetComponent<NavMeshAgent>();
      agent.speed = speed;
   }

   private void Update()
   {
      agent.destination = player.position;
   }
}
