using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public float proyectil_speed ;
    public GameObject impact_effect;
    public Vector2 attack_direction;
    private Rigidbody2D rigidbody;


    void Start()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 attackDirection = (mousePosition - (Vector2)transform.position).normalized;
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = attackDirection * proyectil_speed;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        Debug.Log("choco con algo");

        if (!collision.gameObject.CompareTag("Player"))
        {
            GameObject gm = Instantiate(impact_effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    
}

