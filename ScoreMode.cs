using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text txtScore;
    int iScore = 0;


    public void SetScore()
    {
        iScore += 10;
        txtScore.text = "Score:" + iScore.ToString();
    }
}