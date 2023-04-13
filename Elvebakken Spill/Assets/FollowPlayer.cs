using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public ParticleSystem[] particleSystems;
    public bool followPlayer;

    // Update is called once per frame
    void Update()
    {
        if (!followPlayer) return;
        foreach (ParticleSystem particle in particleSystems)
        {
            ParticleSystem.ShapeModule shapeModule = particle.shape;
            shapeModule.position = new Vector3(player.position.x, 0, player.position.z);
        }
    }
}
