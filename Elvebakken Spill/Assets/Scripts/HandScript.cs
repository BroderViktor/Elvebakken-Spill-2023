using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public float maxDistanceFromPlayer;
    public float timeBeforeAttack;
    public float timeBeforeAttackRandomness;
    void Start()
    {
        StartCoroutine(Attack());
    }
    private void Update()
    {
        //if ((player.transform.position - transform.position).sqrMagnitude > maxDistanceFromPlayer) 
    }
    IEnumerator Attack()
    {
        yield return new WaitForSeconds(timeBeforeAttack + timeBeforeAttackRandomness * Random.value);
        print("Attacked");
    }
}
