using UnityEngine;
using System.Collections;

public class moveRock : MonoBehaviour {
	public float speed;

	public UIManager uiGet;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(-1,0,0)*(speed)*Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "wall") {
			Destroy (gameObject);
		}

	}
}
