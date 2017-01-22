using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public GameObject endScreenUI;
    bool gameEnded;
    bool delayEnded;

    public int score;
    public int bestScore;

    AudioSource death;

	void Awake ()
    {
        SceneManager.sceneLoaded += OnSceneLoad;
        Initialize();
        death = GetComponent<AudioSource>();
        if(PlayerPrefs.HasKey("bestScore")) { bestScore = PlayerPrefs.GetInt("bestScore"); }
    }

    private void OnSceneLoad(Scene arg0, LoadSceneMode arg1)
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

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoad;
    }

    void Update ()
    {
        if (gameEnded)
        {
            endScreenUI.SetActive(true);
            death.Play();

            if (Input.GetButtonDown("Jump") && delayEnded)
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
            PlayerPrefs.SetInt("bestScore", bestScore);
        }
        StartCoroutine(EndGameDelay());
    }

    public void ReloadScene()
    {
        score = 0;
        gameEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator EndGameDelay()
    {
        yield return new WaitForSeconds(0.2f);
        delayEnded = true;
    }

    public bool isDay()
    {
        return GlobalVars.Instance.isDay();
    }
}
