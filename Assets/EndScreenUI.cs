using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndScreenUI : MonoBehaviour
{
    public Text scoreTexts;

    void Awake()
    {
        if (scoreTexts == null)
        {
            try
            {
                scoreTexts = GetComponent<Text>();
            }
            catch
            {
                Destroy(this);
            }
        }
    }

    void Start()
    {
        gameObject.SetActive(false);
        GameManager.Instance.endScreenUI = gameObject;
    }

    void OnEnable()
    {
        if(scoreTexts != null && GameManager.Instance != null)
        {
            if (GameManager.Instance.score > GameManager.Instance.bestScore)
            {
                GameManager.Instance.bestScore = GameManager.Instance.score;
                PlayerPrefs.SetInt("bestScore", GameManager.Instance.bestScore);
            }
            scoreTexts.text = "Score: " + GameManager.Instance.score
                + "\nBest: " + GameManager.Instance.bestScore;
        }
    }
}