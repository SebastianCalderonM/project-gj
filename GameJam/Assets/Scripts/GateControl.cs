using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControl : MonoBehaviour
{
    public GameObject[] gates;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            gates[0].SetActive(true);

            if( gates.Length > 1)
            {
                gates[1].SetActive(true);
            }

            Destroy(gameObject, 4f);
        }
    }
}
