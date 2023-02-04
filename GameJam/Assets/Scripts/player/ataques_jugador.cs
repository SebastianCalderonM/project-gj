using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataques_jugador : MonoBehaviour
{

   public Transform firePosition;
   public GameObject proyectil;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            
            Instantiate(proyectil, firePosition.position, firePosition.rotation);
        }
    }
}
