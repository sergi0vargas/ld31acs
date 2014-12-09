using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MueveLaLlave : MonoBehaviour {

	void Start () {

        GameObject[] ga = GameObject.FindGameObjectsWithTag("Piedra");
        int cual = Random.Range(0, ga.Length);
        ga[cual].GetComponent<HasTheKey>().hasKey = true;        
	}

}
