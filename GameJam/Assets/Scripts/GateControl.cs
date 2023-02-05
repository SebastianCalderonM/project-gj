using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControl : MonoBehaviour
{
    public GameObject[] gates;
    public GameObject[] enemy;
    private GameObject[] enemyCount;

    private bool isActivated = false;

    public int enemyNumber;
    private int enemyType;

    public   Vector3[] spawnPoints = new Vector3[7];

    private void Update()
    {
        if(isActivated == true)
        {
            enemyCount = GameObject.FindGameObjectsWithTag("Enemy");

            if(enemyCount.Length == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && isActivated == false) {
            gates[0].SetActive(true);

            if( gates.Length > 1)
            {
                gates[1].SetActive(true);
            }

            enemyNumber = Random.Range(3, 8);

            for (int i = 0; i < enemyNumber; i++) {

                enemyType = Random.Range(0, enemy.Length);
                Instantiate(enemy[enemyType], transform.position + spawnPoints[i], Quaternion.identity);
            }

            isActivated = true;
        }
    }
}
