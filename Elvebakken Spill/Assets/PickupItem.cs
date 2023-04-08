using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : Interactable
{
    public GameObject objectToEnable;
    public override void OnInteract()
    {
        objectToEnable.SetActive(true);
        Destroy(gameObject);
    }
}
