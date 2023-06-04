using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameStart : MonoBehaviour
{

public void OnClick() 
    {
        Debug.Log("click");
        SceneManager.LoadScene("shooting");
    }   
}
