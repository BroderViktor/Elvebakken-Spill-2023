using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairManager : GameManager
{
    public GameObject Mover;
    public GameObject CurrentStairSpawn;
    public bool spawning;
    public float spawnInterval;
    Coroutine spawner;
    public Vector3 spawnPositionOffset;
    public override void Start()
    {
        base.Start();

    }
    public void StartSpawning()
    {
        print("Started Spawning");
        spawner = StartCoroutine(Spawner());
    }
    public void StopSpawning()
    {
        print("stoppedSpawning");

        StopCoroutine(spawner);
    }
    IEnumerator Spawner()
    {
        for (; ; )
        {
            yield return new WaitForSecondsRealtime(spawnInterval);
            if (Random.value > 0.5f)
                Instantiate(Mover, CurrentStairSpawn.transform.position + spawnPositionOffset, CurrentStairSpawn.transform.rotation, transform);
            else
                Instantiate(Mover, CurrentStairSpawn.transform.position - spawnPositionOffset, CurrentStairSpawn.transform.rotation, transform);
        }
    }
}
