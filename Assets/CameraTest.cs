using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraTest : MonoBehaviour {
    //Bored bored;

	// Use this for initialization
	void Start () {
        //bored = GetComponent<Bored>();
        //bored.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.score >= 5)
        {
            SceneManager.LoadScene("RoniTest2");
        }
       
    }
}
