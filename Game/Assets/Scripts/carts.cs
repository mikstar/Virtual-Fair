using UnityEngine;
using System.Collections;

public class carts : MonoBehaviour {
	
	void Start () 
	{
		renderer.material.color = new Color(Random.value, Random.value, Random.value);
	}
}
