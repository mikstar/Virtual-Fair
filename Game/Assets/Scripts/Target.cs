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
	


	void OnMouseDown ()
	{
		scoreScript.addPoints(pointsWorth);
		Destroy(gameObject);

	}
}
