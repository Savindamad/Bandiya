using UnityEngine;
using System.Collections;

public class batterySpawn : MonoBehaviour {
	public GameObject battery;
	public int randomSpawn = 0;
	public float timeGap;
	public float timeSpawn=0;
	
	public float timeGap1;
	public float timeGap2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeSpawn += Time.deltaTime;
		if (timeSpawn >= timeGap) {
			Instantiate(battery,this.transform.position,this.transform.rotation);
			timeGap=Random.Range(timeGap1,timeGap2);
			timeSpawn=0;
		}
		
	}
	public void setTimeGap(float x, float y){
		timeGap1 = x;
		timeGap2 = y;
	}
}
