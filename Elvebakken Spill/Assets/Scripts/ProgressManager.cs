using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProgressManager : MonoBehaviour
{
    public int currentProgress = 0;

    public string[] questInstructions;
    public TMP_Text questText;

    private void Start()
    {
        UpdateProgressLevel(0);
    }
    public void UpdateProgressLevel(int newLevel)
    {
        if (newLevel > questInstructions.Length - 1) return;
        questText.text = questInstructions[newLevel];
    }
}
