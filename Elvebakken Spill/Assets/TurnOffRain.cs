using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffRain : MonoBehaviour
{
    public GameObject rainParent;
    public bool rainActive;

    private void OnTriggerEnter(Collider other)
    {
        rainParent.SetActive(rainActive);
    }
}
