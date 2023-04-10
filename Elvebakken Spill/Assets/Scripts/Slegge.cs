using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slegge : MonoBehaviour
{
    public Camera cam;
    public LayerMask destroyable;
    private void Update()
    {
        if (!Input.GetMouseButtonDown(0) && !Input.GetKeyDown(KeyCode.R)) return;

        RaycastHit raycastHit;
        if (!Physics.Raycast(cam.transform.position, cam.transform.forward, out raycastHit, 4f, destroyable)) return;
        Destroy(raycastHit.transform.gameObject);
    }
}
