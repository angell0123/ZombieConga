using UnityEngine;
using System.Collections;

public class LivesCreater : MonoBehaviour {
	public GameObject heartPrefab;
	public static int MaxLives = 3;

	// Use this for initialization
	void Start () {
		showlives();
	}
	
	void showlives(){
		float f = 0.6f;
		for (int i = 0; i<MaxLives; i++) {
			float x = 3f + f * i;
			Vector3 heartPos = new Vector3 (x, 2.8f, .0f);
			Instantiate (heartPrefab, heartPos, Quaternion.identity);
		}
	}
}
