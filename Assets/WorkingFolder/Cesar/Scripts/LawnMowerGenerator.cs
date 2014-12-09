using UnityEngine;
using System.Collections;

public class LawnMowerGenerator : MonoBehaviour {

	public GameObject lawnMowerPrefab;
	public int lawnMowerQuantity;
	public int timeBegin;



	public void GenerateLawnMower ()
	{	
		for (int i = 0; i < lawnMowerQuantity; i++)
		{
			GameObject.Instantiate(lawnMowerPrefab);
		}
	}
}
