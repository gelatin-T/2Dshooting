using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObjectMissing : MonoBehaviour
{
    public GameObject gameoverManager; // アタッチするGameObject

    void Update()
    {
        if (gameoverManager == null)
        {
            MissingObjectDetected();
        }
    }

    public void MissingObjectDetected()
    {
        // gameoverManagerがnullでなければGameOver関数を呼び出す
        if (gameoverManager != null)
        {
            gameoverManager.GetComponent<GameOver>().GameOverScene();
        }
    }
}


