using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameLoader : Interactable
{
    public AudioSource doorOpen;
    public string[] ScenesToLoad;
    public string[] ScenesToUnload;
    public void LoadScene()
    {
        foreach (string s in ScenesToLoad)
            SceneManager.LoadScene(s, LoadSceneMode.Additive);
        foreach (string s in ScenesToUnload)
            SceneManager.UnloadSceneAsync(s);
        //SceneManager.LoadScene(scene.name);
    }
    public override void OnInteract()
    {
        LoadScene();
    }
}
