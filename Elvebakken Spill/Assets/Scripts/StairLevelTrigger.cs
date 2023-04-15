using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairLevelTrigger : MonoBehaviour
{
    StairManager gameManager;
    public GameObject spawnPos;
    public LayerMask player;
    private void Start()
    {
        gameManager = FindObjectOfType<StairManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!(player.value == (1 << other.gameObject.layer))) return;
        print("Enter " + other);

        if (gameManager.spawning) return;
        //gameManager.CurrentStairSpawn = spawnPos;
        gameManager.StartSpawning();
        gameManager.spawning = true;
    }
    private void OnTriggerExit(Collider other)
    {

        if (!(player.value == (1 << other.gameObject.layer))) return;
        print("Exit " + other);

        gameManager.StopSpawning();
        gameManager.spawning = false;
    }
}
