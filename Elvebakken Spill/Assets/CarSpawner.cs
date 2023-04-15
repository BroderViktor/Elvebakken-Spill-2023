using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject Car;
    public Transform spawn;
    public bool activeCar;
    private void OnTriggerEnter(Collider other)
    {
        if (!activeCar)
        {
            activeCar = true;
            Instantiate(Car, spawn);
        }

    }
}
