using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    void Start () {
        // unload all scenes except the main menu
        SceneManager.UnloadSceneAsync(1);
        SceneManager.UnloadSceneAsync(2);
        SceneManager.UnloadSceneAsync(3);
        SceneManager.LoadSceneAsync(0);
    }

    public void OnButtonClick() {
        SceneManager.LoadSceneAsync(1);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
    }
}
