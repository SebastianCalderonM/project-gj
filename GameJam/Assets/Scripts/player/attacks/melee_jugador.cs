using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee_jugador : MonoBehaviour
{
    public int attackDamage = 100;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        Debug.Log("colision con algo");
        if (collision.gameObject.tag!="Player")
        Debug.Log("colision con not player");
        {
            if (collision.gameObject.tag !="Map")
            {
                Debug.Log("melee con algo not player y not map");
                //hacer dano
                Enemy enemy = collision.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(attackDamage);
                }
            }
        }
    }
    
}
