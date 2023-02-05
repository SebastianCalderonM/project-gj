using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject proyectil;
    public Transform firePosition;
    public float fireRate = 0.2f;
    private float fireCountdown = 0f;
    public float speed = 1f;
    public float stoppingDistance = 2f;
    public float attackDistance = 7f;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (target != null)
        {
            float distance = Vector2.Distance(transform.position, target.position);
            if (distance < attackDistance)
            {
                // Verifica si la distancia es mayor que la distancia de detención
                if (distance > stoppingDistance)
                {
                    // Calcula la dirección hacia el objetivo
                    Vector2 direction = (target.position - transform.position).normalized;
                    // Mueve el enemigo hacia el objetivo
                    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                }


                
                // Verifica si el contador de fuego ha llegado a cero
                if (fireCountdown <= 0f)
                {
                    Instantiate(proyectil, firePosition.position, firePosition.rotation);
                    fireCountdown = 1f / fireRate;
                }
                // Decrementa el contador de fuego
                fireCountdown -= Time.deltaTime;
            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Lógica para matar al enemigo
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }
}