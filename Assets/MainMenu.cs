using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(GlobalVars.Instance.GameSceneName);
        }
    }
}
