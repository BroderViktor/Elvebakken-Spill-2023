using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnDestroy : MonoBehaviour
{
    public AudioSource audioSource;
    void OnDestroy()
    {
        print("destroyed");
        audioSource.Play();
    }
}
