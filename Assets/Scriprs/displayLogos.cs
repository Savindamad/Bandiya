using UnityEngine;
using System.Collections;

public class displayLogos : MonoBehaviour {
	// Use this for initialization
	void Start () {
		StartCoroutine ("countDown");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private IEnumerator countDown(){
		yield return new WaitForSeconds (6);
		Application.LoadLevel ("Menu");
	}
}
