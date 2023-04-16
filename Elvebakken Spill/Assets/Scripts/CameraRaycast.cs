using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    public AudioSource audioPlayer;
    public LayerMask mask;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit raycastHit;
            if (!Physics.Raycast(transform.position, transform.forward, out raycastHit, 8f, mask)) return;
            Interactable ob = raycastHit.transform.gameObject.GetComponent<Interactable>();

            if (ob != null)
            {
                ob.OnInteract();
                AudioSource audioSource = ob.gameObject.GetComponent<AudioSource>();
                if (audioSource == null) return;
                if (audioSource.clip == null) return;

                audioPlayer.PlayOneShot(audioSource.clip, audioSource.volume);
               
            }
        }
    }
}
