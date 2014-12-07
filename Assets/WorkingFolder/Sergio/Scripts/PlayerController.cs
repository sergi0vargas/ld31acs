using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    public float playerSpeed = 1000;
    public float rotationSpeed = 20;


    private Vector2 input;
    private Animator anim;

    private bool rightWalk = true;
    private bool upWalk = false;
    private bool noMovHorizontal;
    private bool noMovVertical;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        input = new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed, Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed);

        Animaciones();
        RotacionDelSprite();
	}

    void FixedUpdate()
    {
        //Movimiento
        rigidbody2D.AddForce(input);
    }

    void Animaciones()
    {
        if (input.magnitude != 0)
            anim.SetBool("Walking", true);
        else
            anim.SetBool("Walking", false);
    }

    void RotacionDelSprite()
    {
        //Consulta si se esta moviendo en una direccion
        if (input.x > 0){
            rightWalk = true;
            noMovHorizontal = false;
        }
        else if (input.x < 0){
            rightWalk = false;
            noMovHorizontal = false;
        }
        else
            noMovHorizontal = true;

        if (input.y > 0)
        {
            upWalk = true;
            noMovVertical = false;
        }
        else if (input.y < 0)
        {
            upWalk = false;
            noMovVertical = false;
        }
        else
            noMovVertical = true;


        //combina los movimientos en diagonales
        if (!noMovHorizontal && !noMovVertical)
        {
            if (rightWalk && upWalk)
                transform.rotation = Quaternion.Euler(Vector3.forward * 45);
            else if (rightWalk && !upWalk)
                transform.rotation = Quaternion.Euler(Vector3.forward * 315);
            else if (!rightWalk && upWalk)
                transform.rotation = Quaternion.Euler(Vector3.forward * 135);
            else if (!rightWalk && !upWalk)
                transform.rotation = Quaternion.Euler(Vector3.forward * 225);
        }
        else
        {
            if (noMovHorizontal)
            {
                if(upWalk)
                    transform.rotation = Quaternion.Euler(Vector3.forward * 90);
                else

                    transform.rotation = Quaternion.Euler(Vector3.forward * 270);
            }
            if (noMovVertical)
            {
                if (rightWalk)
                    transform.rotation = Quaternion.Euler(Vector3.forward * 0);
                else

                    transform.rotation = Quaternion.Euler(Vector3.forward * 180);
            }
        }
            
            
        
    }
    
}
