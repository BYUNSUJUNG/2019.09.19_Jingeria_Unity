using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public float pipeTime = 2f;
	public float pipeMin = -1f;
	public float pipeMax = 1f;

	public GameObject pipePrefab;

	void Start () {
		StartCoroutine(PipeStart());
	}
	
	IEnumerator PipeStart()
	{
		do
		{
			Instantiate(pipePrefab,
				new Vector3(3.5f, Random.Range(pipeMin,pipeMax),0),
				Quaternion.Euler(new Vector3(0,0,0)));
			yield return new WaitForSeconds(pipeTime);
		} while (true);
	}

}
