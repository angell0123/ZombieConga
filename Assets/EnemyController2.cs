using UnityEngine;
using System.Collections;

public class EnemyController2 : MonoBehaviour {
	public float speed = -2;
	private Transform spawnPoint;
	public GameObject catPrefab;
	
	// Use this for initialization
	void Start () {
		spawnPoint = GameObject.Find("SpawnPoint").transform;
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnBecameInvisible()
	{
		if (Camera.main == null) {
			return;
		}
		float yMax = Camera.main.orthographicSize - 0.5f;
		Vector3 catPos = new Vector3( spawnPoint.position.x, 
		                                 Random.Range(-yMax, yMax), 
		                                 transform.position.z );
		Instantiate(catPrefab, catPos, Quaternion.identity);
	}
}
