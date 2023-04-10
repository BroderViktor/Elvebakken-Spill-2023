using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform startpos; 
    public Transform endpos;
    private void Start()
    {
        FindObjectOfType<PlayerMovement>().transform.position = startpos.position;
        FindObjectOfType<PlayerMovement>().transform.rotation = startpos.rotation;
    }
}
