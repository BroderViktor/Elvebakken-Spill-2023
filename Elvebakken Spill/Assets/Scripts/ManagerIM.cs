using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerIM : GameManager
{
    public bool isSpawning;
    public float HandInterval;
    public float HandIntervalRandomness;
    public float MaxDistanceFromPlayer;
    public GameObject hand;

    GameObject player;
    AudioSource GlobalAudio;
    AudioClip sceneAudio;

    Coroutine spawning;

    public override void Start()
    {
        base.Start();
        player = FindObjectOfType<PlayerMovement>().gameObject;
        foreach (AudioSource source in Resources.FindObjectsOfTypeAll<AudioSource>())
        {
            if (source.tag == "GlobalAudio") GlobalAudio = source;
        }

        GlobalAudio.clip = sceneAudio;
    }
    public void StartSpawning()
    {
        if (isSpawning) return;
        spawning = StartCoroutine(HandSpawner());
        isSpawning = true;
    }
    public void StopSpawning()
    {
        if (!isSpawning) return;
        StopCoroutine(spawning);
        isSpawning = false;
    }
    IEnumerator HandSpawner()
    {
        for (; ; )  {
            yield return new WaitForSecondsRealtime(HandInterval + HandIntervalRandomness * Random.value);
            Vector3 randomDir = new Vector3(Random.value - 0.5f, Random.value - 0.5f, Random.value - 0.5f);
            randomDir = randomDir.normalized;
            RaycastHit hit;
            if (!Physics.Raycast(player.transform.position, randomDir, out hit, MaxDistanceFromPlayer)) continue;
            GameObject handclone = Instantiate(hand, hit.point, Quaternion.identity, transform);
            handclone.transform.LookAt(player.transform);
        }
    }
}
