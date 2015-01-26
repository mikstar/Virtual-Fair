using UnityEngine;
using System.Collections;

public class ScoreSystem : MonoBehaviour {

	private int points = 0;
	public GUIText text;


	
	public void addPoints(int pnts)
	{
		points += pnts;
		text.text = "Score: " + points;
	}
}
