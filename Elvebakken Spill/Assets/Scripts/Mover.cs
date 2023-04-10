using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public LayerMask player;
    public float Speed;
    void FixedUpdate()
    {
        transform.position += transform.forward * Speed;    
    }
    private void OnCollisionEnter(Collision other)
    {
        if (!(player.value == (1 << other.gameObject.layer))) return;
        StairManager s = FindObjectOfType<StairManager>();
        s.TeleportPlayer();
        Destroy(gameObject);

    }
}
