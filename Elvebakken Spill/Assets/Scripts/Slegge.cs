using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slegge : MonoBehaviour
{
    public AudioSource breakSound;
    public Camera cam;
    public LayerMask destroyable;
    public Animator animator;

    public ParticleSystem hitparticles;

    public float cooldown;
    public bool canAttack;
    private void Update()
    {
        if (!Input.GetMouseButtonDown(0) && !Input.GetKeyDown(KeyCode.R)) return;
        if (!canAttack) return;

        canAttack = false;
        StartCoroutine(CanAttack());

        RaycastHit raycastHit;
        if (!Physics.Raycast(cam.transform.position, cam.transform.forward, out raycastHit, 8f)) return;
        
        breakSound.Play();
        Instantiate(hitparticles, raycastHit.point, Quaternion.identity);
        AudioSource source = raycastHit.transform.gameObject.GetComponent<AudioSource>();

        if (!(destroyable.value == (1 << raycastHit.transform.gameObject.layer))) return;

        if (source != null) breakSound.PlayOneShot(source.clip);
        Destroy(raycastHit.transform.gameObject);
    }
    IEnumerator CanAttack()
    {
        yield return new WaitForSeconds(cooldown);
        canAttack = true;
    }
}
