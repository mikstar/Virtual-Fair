using UnityEngine;
using System.Collections;

public class ScoreSystem : MonoBehaviour {

	private int points = 0;
	public GUIText text;

	// Use this for initialization
	void Start () {
	
	}
	
	public void addPoints(int pnts)
	{
		points += pnts;
		text.text = "Score: " + points;
	}
}
