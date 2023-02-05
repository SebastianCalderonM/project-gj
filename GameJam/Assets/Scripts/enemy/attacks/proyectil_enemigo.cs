using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil_enemigo : MonoBehaviour
{
    public float proyectil_speed;
    public GameObject impact_effect;
    public Vector2 attack_direction;
    private new Rigidbody2D rigidbody;
    public int damage = 34;
    [HideInInspector]
    public GameObject player_target;
    public float timeLiveBullet;

    void Start()
    {
        player_target = GameObject.Find("protagonista");
        Vector2 mousePosition = player_target.transform.position;
        Vector2 attackDirection = (mousePosition - (Vector2)transform.position).normalized;
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = attackDirection * proyectil_speed;
        //Destroy dsp de 1 segundos
        Destroy(gameObject, timeLiveBullet);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (!collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("choco");
            vida_jugador player = collision.GetComponent<vida_jugador>();
            if (player != null)
            {
                player.TakeDamage(damage);
            }
            GameObject gm = Instantiate(impact_effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    
}
