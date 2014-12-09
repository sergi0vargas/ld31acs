using UnityEngine;
using System.Collections;

public class LawnMowerController : MonoBehaviour {

	private Vector2 velocity;
    public float speed = 10;

    private float tiempoDeCambio;
    public float maxTiempoCambio = 3;
    public float minTiempoCambio = 0.5f;
    private float tiempo;

	// Use this for initialization
	void Start() 
	{
        /*//Cambiar para que tome dimensiones de la pantalla restando el tamaño de los limites
		Vector3 randomPosition = new Vector3(Random.Range(-7f, 7f), -4.5f, 0);
		transform.position = randomPosition;

		velocity.x = Random.Range (-3, 3);
		velocity.y = Random.Range (0.5f, 4);

		Rigidbody2D rb2d = this.gameObject.AddComponent<Rigidbody2D>();
		rb2d.velocity = velocity;*/
		
		TipoPodadora();
	}
	
    //Cambia color segun tipo
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

        tiempo += Time.deltaTime;
        if (tiempo >= tiempoDeCambio)
        {
            tiempo = 0;
            CambiaDireccion();
            tiempoDeCambio = Random.Range(minTiempoCambio, maxTiempoCambio);
            rigidbody2D.velocity = Vector2.zero;
        }
        /*
		velocity.x = Random.Range (-3, 3);
		velocity.y = Random.Range (0.5f, 4);
		transform.Translate(velocity * Time.deltaTime);*/
	}


    void FixedUpdate()
    {
        Avanzar();
    }


    void Avanzar()
    {
        rigidbody2D.AddForce(transform.up * speed * Time.fixedDeltaTime);
    }
    void CambiaDireccion()
    {
        transform.Rotate(Vector3.forward * (Random.Range(0, 360)));
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Fuck");
            GameManager.manager.ApplyDamage();
        }
        else
        {
            CambiaDireccion();
        }

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (!col.gameObject.tag.Equals("Player"))
        {
            CambiaDireccion();
        }
    }
}
