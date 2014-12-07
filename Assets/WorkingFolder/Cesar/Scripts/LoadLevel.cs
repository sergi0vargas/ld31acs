using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void update(){
	}

	void OnMouseDown() {

		Application.LoadLevel("ld");
	}
}
