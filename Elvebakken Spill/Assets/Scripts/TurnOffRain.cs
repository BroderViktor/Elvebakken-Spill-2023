using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffRain : MonoBehaviour
{
    public GameObject rainParent;
    public bool rainActive;
    public AudioSource rainSource;
    public AudioClip rainSound;

    private void OnTriggerEnter(Collider other)
    {
        rainParent.SetActive(rainActive);
        if (rainSource.clip != rainSound) {
            rainSource.clip = rainSound;
            rainSource.Play();
            if (rainActive)
            {
                //rainSource.volume = 0.7f;
                rainSource.spatialBlend = 0;
            }
            else
            {
                //rainSource.volume = 1;
                rainSource.spatialBlend = 0.95f;
            }
        };
    }
}
