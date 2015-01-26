using UnityEngine;
using System.Collections;

public class carousel : MonoBehaviour {
	
	private float speed = 0.2f;

	void Update()
	{
		this.transform.Rotate(Vector3.up * speed);
			
		if (speed <= 2.5f)
			speed += 0.005f;
			
	}
}
