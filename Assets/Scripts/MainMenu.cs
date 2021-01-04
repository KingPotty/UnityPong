using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    void Start () {
        // unload all scenes except the main menu
        SceneManager.UnloadSceneAsync(0);
        SceneManager.UnloadSceneAsync(1);
        SceneManager.UnloadSceneAsync(2);
        SceneManager.LoadSceneAsync(3);
    }

    public void OnButtonClick() {
        SceneManager.LoadSceneAsync(0);
        SceneManager.UnloadSceneAsync(3);
    }
}
