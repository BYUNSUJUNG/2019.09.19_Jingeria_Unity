using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetrunSceneScript : MonoBehaviour {

	public void RetrunSceneChange() {
		Debug.Log("버튼눌림");
		SceneManager.LoadScene("Main");
	}
}
