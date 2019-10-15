using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UIL;
using UnityEngine.SceneManagement;

public class EndPanelManager : MonoBehaviour {

	public Text Score;
	public Text BextScore;

	public GameObject newImage;
	public GameObject medal;
	public Sprite gold_m;
	public Sprite silver_m;
	public Sprite bronze_m;

	public void OnEnable()
	{
		Socre.Text = GameManager.score.ToString();

		if(GameManager.bestScore < GameManager.score)
		{
			GameManager.bestScore = GameManager.score;
			newImage.SetActive(true);
		}
		else
		{
			newImage.SetActive(false);
		}

		BestScore.text = GamaManager.bestScore.ToString();

		if(GameManager.score >= 10)
		{
			medal.GetComponent<Image>().sprite = gold_m;
		}

		else if
	}
}

