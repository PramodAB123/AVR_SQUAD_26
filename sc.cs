using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sc : MonoBehaviour
{
     public void LoadSceneByName()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void quitapp(){
        Application.Quit();
    }

}
