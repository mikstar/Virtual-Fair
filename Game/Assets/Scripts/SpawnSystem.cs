using UnityEngine;
using System.Collections;

public class SpawnSystem : MonoBehaviour {

	public GameObject[] targetTypes;
	public Transform[] spawnPoints;
	public Transform[] wayPoints;
	public int[] pointsWorth;
	private ScoreSystem scoreScript;
	public float timeBetweenSpawn;
	private float timeToSpawn;

	// Use this for initialization
	void Start () {
		scoreScript = GetComponent<ScoreSystem>();
		timeToSpawn = timeBetweenSpawn;
	}
	
	// Update is called once per frame
	void Update ()
	{
		timeToSpawn -= Time.deltaTime;
		if(timeToSpawn < 0)
		{
			timeToSpawn = timeBetweenSpawn;
			int num = Mathf.CeilToInt(Random.Range(0,targetTypes.Length));
			spawn(targetTypes[num],spawnPoints[Mathf.CeilToInt(Random.Range(0,spawnPoints.Length))].position,pointsWorth[num]);
		}
	}

	private void spawn(GameObject obj, Vector3 pos, int pnts)
	{
		GameObject newSpawn = Instantiate(obj,pos,Quaternion.identity) as GameObject;
		newSpawn.GetComponent<Target>().assighnVars(scoreScript,pnts);
		if(newSpawn.GetComponent<agentt>())
		{
			Transform[] kidWayPoints = new Transform[4];

			for(int i=0;i<3;i++)
			{
				kidWayPoints[i] = wayPoints[Mathf.CeilToInt(Random.Range(0,wayPoints.Length))];
			}
			kidWayPoints[3] = spawnPoints[Mathf.CeilToInt(Random.Range(0,spawnPoints.Length))];

			newSpawn.GetComponent<agentt>().AssignWaypoints(kidWayPoints);
		}

	}
}






