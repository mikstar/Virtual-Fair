using UnityEngine;
using System.Collections;

public class agentt : MonoBehaviour {

	NavMeshAgent agent;
	public Transform[] targets;
	private int waypointIndex = 0;

	void Start()
	{
		agent = GetComponent<NavMeshAgent> ();
	}

	void Update()
	{
		agent.SetDestination (targets[waypointIndex].position);

		if (agent.remainingDistance <= agent.stoppingDistance)
		{
			waypointIndex += 1;
			if (waypointIndex == 4)
			{
				Destroy(gameObject);
			}
		}
	}

	public void AssignWaypoints(Transform[] waypoints)
	{
		targets = waypoints;
	}


	/*	NavMeshAgent agent;
	 *	private int waypointWent = 0;
	 * 
	 * void Start()
	 * {
	 * 		agent = GetComponent<NavMeshAgent>():
	 * 		agent.SetDestination (random.Range(0,waypoints.Lenght));
	 * }
	 * 
	 * void Update()
	 * {
	 * 		if (agent.distance <= 0.5f)
	 * 		{
	 * 			agent.SetDestination (random.Range(0,waypoint.Lenght));
	 * 			waypointWent += 1;
	 * 		}
	 * 
	 * 		if (waypointWent == 3)
	 * 		{
	 * 			agent.SetDestination (random.Range(0,exitWaypoint.Lenght));
	 * 		}
	 * }
	 * 
	 */
}
