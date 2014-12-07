using UnityEngine;
using System.Collections;

public class WalkSound : MonoBehaviour {

	public AudioClip[] landSound;
	private Rigidbody2D cc;
	public float delayMoves;
	private float delay;
	private float next;
	private AudioClip walk;

	// Use this for initialization
	void Start () {
		cc = this.gameObject.GetComponent<Rigidbody2D>();
		delay = delayMoves;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (cc.velocity.magnitude > 0.1f & Time.time > next)
		{
			next = Time.time + delayMoves;
			RaycastHit hit;
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
			{
				walk = landSound[Random.Range(0, 4)];
				audio.clip = walk;
				audio.Play();
			}
		}
		delayMoves = delay;
	}
}
