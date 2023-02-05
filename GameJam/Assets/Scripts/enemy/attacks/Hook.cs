using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public float proyectil_speed;
    public GameObject impact_effect;
    public Vector2 attack_direction;
    private new Rigidbody2D rigidbody;
    public int damage = 1;
    [HideInInspector]
    public GameObject player_target;
    public Vector2 GrabberPosition;
    public float timeLiveBullet;

    void Start()
    {
        player_target = GameObject.Find("protagonista");
        GrabberPosition = GameObject.Find("Grabber Enemy").transform.position;
        Vector2 mousePosition = player_target.transform.position;
        Vector2 attackDirection = (mousePosition - (Vector2)transform.position).normalized;
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = attackDirection * proyectil_speed;

        Destroy(gameObject, timeLiveBullet);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (!collision.gameObject.CompareTag("Enemy"))
        {
            vida_jugador player = collision.GetComponent<vida_jugador>();
            if (player != null)
            {
                player.TakeDamage(damage);
                // atraer al player
                while (Vector2.Distance(GrabberPosition, player_target.transform.position) > 0.3f)
                {
                    player_target.transform.position = Vector2.MoveTowards(player_target.transform.position, GrabberPosition, proyectil_speed * Time.deltaTime);
                }
                // El jugador ha sido atrapado
                // Haga lo que quiera con el jugador aquí
                Debug.Log("El jugador ha sido atrapado");
                
            }
            //GameObject gm = Instantiate(impact_effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}