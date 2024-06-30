using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Initial Level");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
