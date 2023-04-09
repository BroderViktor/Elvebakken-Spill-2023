using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform gamePos;
    public Transform playerPos;
    public virtual void Start()
    {
        transform.position = gamePos.transform.position;

        TeleportPlayer();
    }
    public void TeleportPlayer()
    {
        CharacterController charController = FindObjectOfType<CharacterController>();
        charController.enabled = false;
        charController.transform.position = playerPos.position;
        charController.transform.rotation = playerPos.rotation;
        charController.enabled = true;
    }
}
