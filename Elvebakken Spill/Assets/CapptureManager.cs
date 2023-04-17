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
    public float TimeToCompletion;


    public override void Start()
    {
        transform.position = gamePos.transform.position;

        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner()
    {
        for (; ; )
        {
            yield return new WaitForSecondsRealtime(spawnInterval);

            Vector3 spawnPos = (spawnPositionOffset * Random.value) - (spawnPositionOffset / 2);
            print(spawnPos);
            Instantiate(hand, spawnPos, Quaternion.identity, spawnPosition);
        }
    }
}
