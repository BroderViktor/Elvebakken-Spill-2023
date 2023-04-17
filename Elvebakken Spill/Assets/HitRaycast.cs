using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRaycast : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out raycastHit)) return;
            HandChaser ob = raycastHit.transform.gameObject.GetComponent<HandChaser>();

            if (ob) Destroy(ob.gameObject);
        }
    }
}
