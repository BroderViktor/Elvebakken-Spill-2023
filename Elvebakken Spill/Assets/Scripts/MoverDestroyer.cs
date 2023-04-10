using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverDestroyer : MonoBehaviour
{
    public LayerMask mover;
    private void OnTriggerEnter(Collider other)
    {
        if (!(mover.value == (1 << other.gameObject.layer))) return;
        Destroy(other.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        if (!(mover.value == other.gameObject.layer)) return;
        Destroy(other.gameObject);
    }
}
