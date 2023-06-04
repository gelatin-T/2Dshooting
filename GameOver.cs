using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameoverTxt;
    public GameObject pengin;

    void Start()
    {
        gameoverTxt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pengin == null)
        {
            GameOverScene();
        }
        // if(gameoverTxt.activeSelf == true)
        // {
        //     if(Input.GetKeyDown(KeyCode.Space))
        //     {
        //         SceneManager.LoadScene("shooting");
        //     }
        // }
    }

    public void GameOverScene()
    {
        gameoverTxt.SetActive(true);
        Time.timeScale = 0; // 時間を停止する
    }
}
