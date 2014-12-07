using UnityEngine;
using System.Collections;

public class TriggerGuadana : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D col)
	{
		GameObject soundController = GameObject.Find("SoundController");
		soundController.SendMessage("PlayDeadSound");

		Destroy(col.gameObject);

	}
}
