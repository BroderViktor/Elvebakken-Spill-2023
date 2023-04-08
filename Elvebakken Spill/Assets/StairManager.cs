using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairManager : GameManager
{
    public GameObject StartPlatform;
    public GameObject stairPrefab;
    public GameObject finalStairPrefab;
    public int lenght;
    private void Start()
    {
        print("stairgame started");
        MapGen();
        StartPlatform.transform.position = gamePos.position;
        TeleportPlayer();
    }
    void MapGen()
    {
        for (int i = 0; i < lenght; i++)
        {
            Vector3 pos = new Vector3(-stairPrefab.transform.localScale.x * 2 * i, stairPrefab.transform.localScale.z * 2 * i, 0) ;
            pos += gamePos.position;
            if (i == lenght - 1) Instantiate(finalStairPrefab, pos, stairPrefab.transform.rotation);
            else Instantiate(stairPrefab, pos, stairPrefab.transform.rotation, transform);
        }
    }
}
