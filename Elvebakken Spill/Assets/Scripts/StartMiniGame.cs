using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMiniGame : MonoBehaviour
{
    public ManagerIM managerIM;
    private void OnTriggerEnter(Collider other)
    {
        managerIM.StartSpawning();
    }
}
