using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoStartScene : MonoBehaviour
{
    public string SceneToLoad;

    private void Start()
    {
        SceneManager.LoadScene(SceneToLoad, LoadSceneMode.Additive);
    }
}
