using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    private Rigidbody2D rb; // Rigidbody2D para el movimiento físico del jugador
    Vector2 input;  // Vector para almacenar la entrada de movimiento del jugador
    public float speed; // Velocidad de movimiento del jugador

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtenemos el Rigidbody2D del jugador
    }

    void Update()
    {
        input.x = Input.GetAxis("Horizontal"); // Capturamos la entrada de movimiento horizontal
        input.y = Input.GetAxis("Vertical");   // Capturamos la entrada de movimiento vertical
    }
    
    private void FixedUpdate()
    {
        // Aplicamos el movimiento al Rigidbody2D del jugador
        rb.velocity = input * speed * Time.fixedDeltaTime;

        // Limitamos la posición del jugador en el eje x dentro de la zona de juego
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, -6f, 6f), Mathf.Clamp(rb.position.y, -3.3f, 3.33f));
    }

    // Método llamado cuando el jugador colisiona con otro objeto
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Detecta una colisión");
        
        // Destruimos el objeto con el que colisiona el jugador
        Destroy(collision.gameObject);
    }
}