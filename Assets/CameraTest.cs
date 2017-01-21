using UnityEngine;
using System.Collections;

public class CameraTest : MonoBehaviour {
    Bored bored;

	// Use this for initialization
	void Start () {
        bored = GetComponent<Bored>();
        bored.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.score >= 5)
        {
            bored.enabled = true;
        }
        if (GameManager.Instance.score >= 10)
        {
            bored.enabled = false;
        }
    }
}
