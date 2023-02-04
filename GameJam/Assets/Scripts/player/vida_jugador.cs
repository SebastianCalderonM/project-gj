using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida_jugador : MonoBehaviour
{
    public int health = 100;
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
        // Lógica para matar al jugador
        Debug.Log("Player died");
        //Destroy(gameObject);
    }
}
