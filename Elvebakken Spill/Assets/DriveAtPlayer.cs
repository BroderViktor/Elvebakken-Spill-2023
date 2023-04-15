using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveAtPlayer : MonoBehaviour
{
    GameObject player;
    public LayerMask playerMask;
    public float speed;
    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }
    void FixedUpdate()
    {
        transform.LookAt(player.transform.position);
        transform.position += transform.forward * speed;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!(playerMask.value == (1 << other.gameObject.layer))) return;
        print("Døde");
        FindObjectOfType<CarSpawner>().activeCar = false;
        Destroy(gameObject);
    }
}
