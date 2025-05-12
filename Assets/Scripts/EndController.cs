using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndController : MonoBehaviour
{
    public void OnBackToStart()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
