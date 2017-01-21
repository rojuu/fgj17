using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {
    public GameObject capsule;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("CreateObstacle", 0f, 1.5f);
	}
	
	// Update is called once per frame
	void CreateObstacle ()
    {
        Instantiate(capsule);
    }

}
