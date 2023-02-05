using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida_jugador : MonoBehaviour
{
    public GameOver gameOver;
    public int health = 100;
    public Slider healthBar;
    private void Update()
    {
        healthBar.value = health;
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
        // Lógica para matar al jugador
        Debug.Log("Player died");
        //Destroy(gameObject);
        gameOver.GOver();

    }
}
