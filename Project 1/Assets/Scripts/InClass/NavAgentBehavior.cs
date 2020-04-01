using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehavior : MonoBehaviour
{
   private NavMeshAgent agent;
   public Transform player;
   public float speed = 8f;
   private Transform currentDestination;
   private int i;
   private bool canHunt;

   public List<Transform> patrolPoints;
   
   private void Start()
   {
      agent = GetComponent<NavMeshAgent>();
      agent.speed = speed;
      currentDestination = transform;
   }

   private void OnTriggerEnter(Collider other)
   {
      canHunt = true;
      currentDestination = player;
   }

   private void OnTriggerExit(Collider other)
   {
      canHunt = false;
      currentDestination = transform;
   }

   private void Update()
   {
      if (canHunt)
      {
         agent.destination = currentDestination.position;
         return;
      }

      if (!agent.pathPending && agent.remainingDistance < 0.5f)
      {
         agent.destination = patrolPoints[i].position;
         i = (i + 1) % patrolPoints.Count;
      }
   }
}
