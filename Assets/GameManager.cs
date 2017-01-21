using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    GameObject endScreenUI;
    bool gameEnded;
    bool delayEnded;

	void Awake ()
    {
	    if(Instance == null) { Instance = this; }
        if(Instance != this) { Destroy(gameObject); }

        endScreenUI = FindObjectOfType<EndScreenUI>().gameObject;
        endScreenUI.SetActive(false);

    }

	void Update ()
    {
        if (gameEnded)
        {
            if (Input.GetKeyDown(KeyCode.Space) && delayEnded)
            {
                delayEnded = false;
                ReloadScene();
            }
        }
	}

    public void EndGame()
    {
        gameEnded = true;
        endScreenUI.SetActive(true);
        StartCoroutine(EndGameDelay());
    }

    public void ReloadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator EndGameDelay()
    {
        yield return new WaitForSeconds(0.5f);
        delayEnded = true;
    }
}
