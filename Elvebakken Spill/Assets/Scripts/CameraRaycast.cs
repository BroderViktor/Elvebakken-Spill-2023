using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    public LayerMask mask;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit raycastHit;
            if (!Physics.Raycast(transform.position, transform.forward, out raycastHit, 4f, mask)) return;
            Interactable ob = raycastHit.transform.gameObject.GetComponent<Interactable>();

            if (ob != null)
            {
                ob.OnInteract();
            }
        }
    }
}
