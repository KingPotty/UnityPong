using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goals : MonoBehaviour
{
    public int score;
    public int targetScore = 5;
    public int victoryScreenIndex;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    [System.Obsolete]
    public void IncrementScore () {
        score += 1;
        if (score == targetScore) {
            SceneManager.LoadSceneAsync(victoryScreenIndex);
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        }
    }
}
