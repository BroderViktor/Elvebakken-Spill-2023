using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressUpdater : MonoBehaviour
{
    public int progressLevel;
    public ProgressManager progressManager;
    private void OnTriggerEnter(Collider other)
    {
        if (progressManager == null) progressManager = FindObjectOfType<ProgressManager>();
        if (progressManager.currentProgress > progressLevel) return;
        progressManager.UpdateProgressLevel(progressLevel);
    }
}
