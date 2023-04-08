using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform gamePos;
    private void Start()
    {
        TeleportPlayer();
    }
    public void TeleportPlayer()
    {
        CharacterController charController = FindObjectOfType<CharacterController>();
        charController.enabled = false;
        charController.transform.position = gamePos.position;
        charController.transform.rotation = gamePos.rotation;
        charController.enabled = true;
    }
}
