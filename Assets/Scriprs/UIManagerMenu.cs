using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManagerMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void play(){
		Application.LoadLevel("playMode");
	}
	public void Settings(){
	}
	public void Exit(){
		Application.Quit();
	}
	public void Info(){
	}
}
