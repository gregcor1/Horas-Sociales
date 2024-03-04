using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour{

/* Declaramos el Rigidbody2D para que el cuerpo se pueda tomar como un obejto solido y se pueda controlar
 el Vector2 es para que detecte el eje x y y que son los cuales este se movera
y la speed es la velocidad con la que se hara*/
    private Rigidbody2D rb;
    Vector2 input;	
    public float speed;
    
    void Start()

	{
        //lo declaramos y conectamos
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()

    {
        // para que se pueda mover en esos ejes
        input.x = Input.GetAxis("Horizontal");
	    input.y = Input.GetAxis("Vertical");
       
     }
	
	private void FixedUpdate()
	{
        // multiplicación de variables
		rb.velocity = input * speed * Time.fixedDeltaTime;
	}
    
}