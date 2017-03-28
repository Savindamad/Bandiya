using UnityEngine;
using System.Collections;

public class moveTrack : MonoBehaviour {
	public float speed;
	Vector2 offset;

	public UIManager uiGet;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
