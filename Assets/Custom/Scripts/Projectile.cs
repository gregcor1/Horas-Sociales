using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f; // Velocidad del proyectil

    void Update()
    {
        // Mueve el proyectil hacia adelante
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Destruye el proyectil si colisiona con otro objeto
        Destroy(gameObject);
    }
}
