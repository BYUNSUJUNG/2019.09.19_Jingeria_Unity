using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour {

	public float pipeSpeed = 4f;

	private void Update()
	{
		transform.Translate(-pipeSpeed * Time.deltaTime, 0, 0);

		if(transform.position.x <= -4f)
		{
			Destroy(gameObject);
		}


	}

}
