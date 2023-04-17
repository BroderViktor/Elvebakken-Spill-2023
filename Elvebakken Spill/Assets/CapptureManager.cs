using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapptureManager : GameManager
{
    public Slider slider;
    public Transform spawnPosition;
    public Vector3 spawnPositionOffset;
    public GameObject hand;

    public float spawnInterval;
    public float spawnGrowth;

    public float TimeToCompletion;
    float CurrentTime;


    public override void Start()
    {
        transform.position = gamePos.transform.position;

        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime = Time.time;
    }

    IEnumerator Spawner()
    {
        for (; ; )
        {
            yield return new WaitForSecondsRealtime(spawnInterval);
            spawnInterval /= spawnGrowth;

            Vector3 spawnPos = spawnPosition.position + (spawnPositionOffset * Random.value) - (spawnPositionOffset / 2);
            GameObject handClone = Instantiate(hand, spawnPosition);
            handClone.transform.position = spawnPos;
        }
    }
}
