using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public Text score;
	public Text highScore;
	public int scoreCount;
	public int highScoreCount;

	public int count=24;
	public float timeCount=0f;

	bool gameOver;

	public Button play;
	public Button replay;
	public Button home;
	public Button exit;

	public GameObject gameOverTest;
	public GameObject pauseTest;

	public GameObject[] battryLevel;

	public rockSpawnPos rk;
	public batterySpawn bt;
	public jumpBoy jb;

	// Use this for initialization
	void Start () {
		gameOver = false;
		scoreCount = 0;
		highScoreCount = 0;
		InvokeRepeating ("scoreUpdate",1.0f,0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		timeCount += Time.deltaTime;
		if (timeCount > 2f && (!gameOver)) {
			if(count>0){
				battryLevel[count-1].SetActive (false);
				count--;
				if(count==0){
					jb.selfCollide();
					this.GameOver();
				}
			}
			timeCount=0f;
		}
		score.text = "Score : " + scoreCount;
		highScore.text = "High Score : " + highScoreCount;
	}

	void scoreUpdate(){
		if (!gameOver) {
			scoreCount++;
			if (highScoreCount < scoreCount) {
				highScoreCount=scoreCount;
			}
		}
		if (scoreCount == 100) {
			rk.setTimeGap(1.4f,4.5f);
			bt.setTimeGap(40,60);
		}
		if (scoreCount == 200) {
			rk.setTimeGap(1.3f,5f);
			bt.setTimeGap(45,70);
		}
		if (scoreCount == 300) {
			rk.setTimeGap(1.2f,4f);
			bt.setTimeGap(50,75);
		}
		if (scoreCount == 400) {
			rk.setTimeGap(1.2f,3.5f);
			bt.setTimeGap(60,80);
		}
	}
	public void GameOver(){
		gameOver = true;
		gameOverTest.SetActive (true);
		replay.gameObject.SetActive(true);
		home.gameObject.SetActive(true);
		exit.gameObject.SetActive(true);
	}

	public void pause(){
		if (Time.timeScale == 1) {
			Time.timeScale=0;
			pauseTest.SetActive (true);
			play.gameObject.SetActive(true);
			home.gameObject.SetActive(true);
			exit.gameObject.SetActive(true);
		}
	}
	public void Play(){
		pauseTest.SetActive (false);
		play.gameObject.SetActive(false);
		home.gameObject.SetActive(false);
		exit.gameObject.SetActive(false);
		Time.timeScale = 1;
	}
	public void Replay(){
		Application.LoadLevel("test");
	}
	public void Home(){
		Application.LoadLevel("Menu");
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}
	public void Exit(){
		Application.Quit ();
	}
	public void incrementCount(){
		if (count + 8 > 24) {
			for(; count<24; ){
				battryLevel[count].SetActive(true);
				count++;
			}
		} 
		else {
			int i = count+8;
			for(;count<i;){
				battryLevel[count].SetActive(true);
				count++;
			}
		}
	}
}
