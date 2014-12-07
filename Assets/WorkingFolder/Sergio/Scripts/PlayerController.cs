using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public float playerSpeed = 1000;
    public float rotationSpeed = 20;


    private Vector2 input;


	// Use this for initialization
	void Start () {

        Debug.Log(Vector3.forward);

	}
	
	// Update is called once per frame
	void Update () {

        input = new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed, Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed);
        
        //Moviemiento sin fisicas
        //transform.Translate(new Vector3(input.x, input.y, 0));
	}

    void FixedUpdate()
    {
        //Movimiento
        rigidbody2D.AddForce(input);

        //ROTACION!!!
        {
            if (input.magnitude != 0)
                if (input.y > 0)
                {
                    if (input.x > 0)
                    {
                        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.forward * 360), Time.deltaTime);
                        transform.rotation = Quaternion.Euler(Vector3.forward * 1);

                    } if (input.x < 0)
                    {
                        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.forward * 180), Time.deltaTime);
                        transform.rotation = Quaternion.Euler(Vector3.forward * 180);
                    }
                    else
                    {
                        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.forward * 90), Time.deltaTime);
                        transform.rotation = Quaternion.Euler(Vector3.forward * 90);
                    }
                }
                else
                {
                    if (input.x > 0)
                    {
                        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.forward * 360), Time.deltaTime);
                        transform.rotation = Quaternion.Euler(Vector3.forward * 0);

                    } if (input.x < 0)
                    {
                        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.forward * 180), Time.deltaTime);
                        transform.rotation = Quaternion.Euler(Vector3.forward * 180);
                    }
                    else
                    {
                        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.forward * 270), Time.deltaTime);
                        transform.rotation = Quaternion.Euler(Vector3.forward * 270);
                    }
                }
        }

    }
}
