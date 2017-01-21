using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUpdater : MonoBehaviour {

    Text text;
    float score;

	void Start ()
    {
        text = GetComponent<Text>();
        if(text == null) { Destroy(this); }
        score = 0;
        text.text = "Score: " + score;
	}

    void Update()
    {
        if(score != GameManager.Instance.score)
        {
            score = GameManager.Instance.score;
            text.text = "Score: " + score;
        }
    }
}
