using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataques_jugador : MonoBehaviour
{

    public Transform firePosition;
    public GameObject proyectil;

    public Transform golpePosition;
    public GameObject golpe;
    public float golpeRate = 2f;
    private float nextGolpe = 0f;
    public float fireRate = 0.5f;
    private float nextFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(proyectil, firePosition.position, firePosition.rotation);
        }

        if (Input.GetMouseButtonDown(0) && Time.time > nextGolpe)
        {
            nextGolpe = Time.time + golpeRate;
            Instantiate(golpe, golpePosition.position, golpePosition.rotation, transform);
        }
    }
}
