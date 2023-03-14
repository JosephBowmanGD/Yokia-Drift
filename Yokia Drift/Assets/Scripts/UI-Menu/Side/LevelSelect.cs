using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public string Race1;
    public string Race2;
    public string Race3;
    public string Race4;

    public void Return()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadRaces()
    {
        SceneManager.LoadScene(Race1);
    }

    public void LoadRaces1()
    {
        SceneManager.LoadScene(Race2);
    }

    public void LoadRaces2()
    {
        SceneManager.LoadScene(Race3);
    }

    public void LoadRaces3()
    {
        SceneManager.LoadScene(Race4);
    }
}
