using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogOpener : Interactable
{
    public bool raycast;
    public bool trigger;

    public string[] dialog;
    public int dialogNum = 0;
    public float dialogTime = 5.0f;

    public TMP_Text dialogBox;
    Coroutine hideDialog;

    private void Start()
    {
        foreach (DialogClass dia in Resources.FindObjectsOfTypeAll<DialogClass>()) dialogBox = dia.GetComponent<TMP_Text>();
    }
    void DisplayDialog()
    {
        dialogBox.transform.parent.gameObject.SetActive(true);
        if (dialogNum == dialog.Length)
        {
            dialogBox.transform.parent.gameObject.SetActive(false);
            dialogNum = 0;
            return;
        }

        dialogBox.text = dialog[dialogNum];
        dialogNum++;
        if (hideDialog != null) StopCoroutine(hideDialog);
        hideDialog = StartCoroutine(HideDialog());
    }
    IEnumerator HideDialog()
    {
        yield return new WaitForSeconds(dialogTime);
        dialogBox.transform.parent.gameObject.SetActive(false);
        dialogNum = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (trigger) DisplayDialog();
    }
    public override void OnInteract()
    {
        if (raycast) DisplayDialog();
    }
}
