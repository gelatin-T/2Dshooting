using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMode : MonoBehaviour
{
    public Text txtScore;
    int iScore = 0;
    
    void Start()
    {
        txtScore.text = "Score:" + iScore;
    }
    public void SetScore()
    {
        iScore += 10;
        txtScore.text = "Score:" + iScore;
    }
}
