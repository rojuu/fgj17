using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == GlobalVars.Instance.MainMenuSceneName)
                Application.Quit();
            else if (SceneManager.GetActiveScene().name == GlobalVars.Instance.CreditsSceneName)
                SceneManager.LoadScene(GlobalVars.Instance.MainMenuSceneName);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SceneManager.GetActiveScene().name == GlobalVars.Instance.MainMenuSceneName)
                LoadGameScene();
        }
    }

    public void LoadGameScene()
    {
       SceneManager.LoadScene(GlobalVars.Instance.GameSceneName);
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene(GlobalVars.Instance.CreditsSceneName);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(GlobalVars.Instance.MainMenuSceneName);
    }
}
