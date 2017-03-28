using UnityEngine;
using System.Collections;

public class jumpBoy : MonoBehaviour {
	public UIManager ui;
	public float boyPosY;
	public float jumpHight;
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (transform.position.y <= boyPosY) {	 	
				rb.velocity = new Vector3 (0, jumpHight, 0);
			}
		}

	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "rock") {
			Destroy (gameObject);
			ui.GameOver();
		}
		if (col.gameObject.tag == "battery") {
			Destroy(col.gameObject);
			ui.incrementCount();
		}
		
	}
	public void selfCollide(){
		Destroy (gameObject);
	}
}
