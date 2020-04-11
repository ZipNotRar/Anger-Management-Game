using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void ExitScene()
    {
        Application.Quit();
    }
    public void Choice1Scene()
    {
        SceneManager.LoadScene("Choice_1_Scene");
    }

    public void Choice2Scene()
    {
        SceneManager.LoadScene("Choice_2_Scene");
    }
    public void AfterCh1Scene()
    {
        SceneManager.LoadScene("BreathingScene");
    }
    public void AfterCh2Scene()
    {
        SceneManager.LoadScene("BreathingScene");
    }
    public void TherapistScene()
    {
        SceneManager.LoadScene("TherapistScene");
    }
}
