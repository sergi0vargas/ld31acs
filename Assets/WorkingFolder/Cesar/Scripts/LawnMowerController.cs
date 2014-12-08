using UnityEngine;
using System.Collections;

public class LawnMowerController : MonoBehaviour {

	private Vector2 velocity;

	// Use this for initialization
	void Start() 
	{
		Vector3 randomPosition = new Vector3(Random.Range(-7f, 7f), -4.5f, 0);
		transform.position = randomPosition;

		velocity.x = Random.Range (-3, 3);
		velocity.y = Random.Range (0.5f, 4);

		Rigidbody2D rb2d = this.gameObject.AddComponent<Rigidbody2D>();
		rb2d.velocity = velocity;
		
		TipoPodadora();
	}
	
	public void TipoPodadora ()
	{
		float probability = Random.Range (0f, 1f);
		if (probability >= 0 && probability < 0.65f) 
			GetComponent<SpriteRenderer> ().color = Color.red;
	
		else if (probability >= 0.65f && probability < 0.9f)
			GetComponent<SpriteRenderer> ().color = Color.cyan;

		else if (probability >= 0.9f)
			GetComponent<SpriteRenderer> ().color = Color.magenta;
	}
	
	// Update is called once per frame
	void Update () {
	
		velocity.x = Random.Range (-3, 3);
		velocity.y = Random.Range (0.5f, 4);
		transform.Translate (velocity * Time.deltaTime);
	}
}
