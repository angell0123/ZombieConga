using UnityEngine;

public class CatUpdater2 : MonoBehaviour {
	
	private CatController2 catController;
	
	// Use this for initialization
	void Start () {
		catController = transform.parent.GetComponent<CatController2>();  
	}
	
	void UpdateTargetPosition()
	{
		catController.UpdateTargetPosition();
	}
	
	//	void OnBecameInvisible() {
	//		catController.OnBecameInvisible();
	//	}
	
	void GrantCatTheSweetReleaseOfDeath()
	{
		Destroy( transform.parent.gameObject );
	}
}