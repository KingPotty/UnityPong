using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Goals goalLeft;
    public Goals goalRight;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = goalLeft.score + " - " + goalRight.score;
    }
}
