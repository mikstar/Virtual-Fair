using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public ScoreSystem scoreScript; //turn to private after debug phase
	public int pointsWorth;

	// Use this for initialization
	public void assighnVars (ScoreSystem scr, int pnts) {
		scoreScript = scr;
		pointsWorth = pnts;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown ()
	{
		Debug.Log("Hit");
		scoreScript.addPoints(pointsWorth);
		Destroy(gameObject);
	}
}
