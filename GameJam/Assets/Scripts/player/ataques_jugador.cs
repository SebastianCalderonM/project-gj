using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataques_jugador : MonoBehaviour
{

   public Transform firePosition;
   public GameObject proyectil;

   public Transform golpePosition;
   public GameObject golpe;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // disparar
        {   
            Instantiate(proyectil, firePosition.position, firePosition.rotation);
        }

        if (Input.GetMouseButtonDown(0)) // ataque melee
        {
            Instantiate(golpe, golpePosition.position, golpePosition.rotation, transform);
        }
    }
}
