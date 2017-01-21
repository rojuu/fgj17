using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public GameObject endScreenUI;
    bool gameEnded;
    bool delayEnded;

    public int score;
    public int bestScore;

	void Awake ()
    {
        Initialize();
    }

    void OnLevelWasLoaded()
    {
        Initialize();
    }

    void Initialize()
    {
        if (Instance == null) { Instance = this; }
        if (Instance != this) { Destroy(gameObject); }

        DontDestroyOnLoad(this);
        DontDestroyOnLoad(gameObject);
    }

    void Update ()
    {
        if (gameEnded)
        {
            endScreenUI.SetActive(true);

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
        if(score > bestScore)
        {
            bestScore = score;
        }
        StartCoroutine(EndGameDelay());
    }

    public void ReloadScene()
    {
        score = 0;
        gameEnded = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator EndGameDelay()
    {
        yield return new WaitForSeconds(0.2f);
        delayEnded = true;
    }
}
