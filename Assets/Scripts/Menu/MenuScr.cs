using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScr : MonoBehaviour
{
    private SceneManager _sceneManager;

    public GameObject creditsPanel;

    void Start()
    {
        creditsPanel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void PlayGame(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
    }

    public void Back()
    {
        creditsPanel.SetActive(false);
    }
}
