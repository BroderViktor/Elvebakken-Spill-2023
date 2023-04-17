using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandChaser : MonoBehaviour
{
    public GameObject player;
    public LayerMask playerMask;
    public float speed;
    void Start()
    {
        player = FindObjectOfType<PlayerDefence>().gameObject;
        transform.LookAt(player.transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!(playerMask.value == (1 << other.gameObject.layer))) return;
        print("døde");
        Destroy(gameObject);
    }
}
