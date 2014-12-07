using UnityEngine;
using System.Collections;

public class LawnMowerController : MonoBehaviour {

	private int type;
	private Vector2 velocity;

	// Use this for initialization
	void Start() 
	{
		Vector3 randomPosition = new Vector3(Random.Range(-8f, 8f),-6,0);
		Vector3 randomScale = Vector3.one * Random.Range(0.5f, 2f);
		
		transform.localScale = randomScale;
		transform.position = randomPosition;
		
		velocity.x = Random.Range (-3, 3);
		velocity.y = Random.Range (0.5f, 4);
		
		rigidbody2D.velocity = velocity;
		
		TipoPodadora();
	}
	
	public void TipoPodadora ()
	{
		float probability = Random.Range (0f, 1f);
		if (probability >= 0 && probability < 0.65f) 
		{
			type = 0;
			GetComponent<SpriteRenderer> ().color = Color.yellow;
		}
		else if (probability >= 0.65f && probability < 0.9f) 
		{
			type = 1;
			GetComponent<SpriteRenderer> ().color = Color.cyan;
		}
		else if (probability >= 0.9f) 
		{
			type = 2;
			GetComponent<SpriteRenderer> ().color = Color.magenta;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
