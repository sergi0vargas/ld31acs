using UnityEngine;
using System.Collections;

public class TriggerGuadana : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals("Player")){
			GameObject soundController = GameObject.Find("SoundController");
			soundController.SendMessage("PlayDeadSound");

			Destroy(col.gameObject);
		}

	}
}
