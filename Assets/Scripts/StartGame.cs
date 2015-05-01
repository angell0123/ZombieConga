using UnityEngine;

public class StartGame : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		//Invoke("LoadLevel", 3f);
	}

	public void SGame(){
		Invoke("LoadLevel",.5f);
	}

	public void SGame2(){
		Invoke("LoadLevel2",.5f);
	}

	void LoadLevel() {
		Application.LoadLevel("CongaScene");
	}
	void LoadLevel2() {
		Application.LoadLevel ("CongaScene2");
	}
}