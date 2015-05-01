//test for GitHub
using UnityEngine;
using System.Collections;

public class heartController : MonoBehaviour {
	public float moveSpeed;
	private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
		moveDirection = Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		Vector3 target = moveDirection * moveSpeed + currentPosition;
		transform.position = Vector3.Lerp( currentPosition, target, Time.deltaTime );

	}

	public void destroyHeart(){
		Destroy (gameObject);
	}
}
