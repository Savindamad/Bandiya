using UnityEngine;
using System.Collections;

public class rockSpawnPos : MonoBehaviour {
	public GameObject[] rock;
	public int rockNum;
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
			rockNum = Random.Range(0,4);
			Instantiate(rock[rockNum],this.transform.position,this.transform.rotation);
			timeGap=Random.Range(timeGap1,timeGap2);
			timeSpawn=0;
		}

	}
	public void setTimeGap(float x, float y){
		timeGap1 = x;
		timeGap2 = y;
	}
}
