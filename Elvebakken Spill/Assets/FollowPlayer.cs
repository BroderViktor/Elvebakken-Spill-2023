using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public bool followPlayer;

    // Update is called once per frame
    void Update()
    {
        if (!followPlayer) return;
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
}
