using UnityEngine;
using System.Collections;

public class SpawnSystem : MonoBehaviour {

	public GameObject[] targetTypes;
	public int[] pointsWorth;
	private ScoreSystem scoreScript;

	public Transform[] SpawnPoints;

	// Use this for initialization
	void Start () {
		scoreScript = GetComponent<ScoreSystem>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	private void spawn(GameObject obj, Vector3 pos, int pnts)
	{
		GameObject newSpawn = Instantiate(obj,pos,Quaternion.identity) as GameObject;
		newSpawn.GetComponent<Target>().assighnVars(scoreScript, pnts);
	}
}
