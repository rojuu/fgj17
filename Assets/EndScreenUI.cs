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

    void OnEnable()
    {
        int score = 5;
        int bestScore = 40;
        scoreTexts.text = "Score: " + score + "\nBest: " + bestScore;
    }
}