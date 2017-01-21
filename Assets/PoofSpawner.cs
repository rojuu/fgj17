using UnityEngine;
using System.Collections;

public class PoofSpawner : MonoBehaviour
{
    public GameObject poofPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instance = Instantiate(poofPrefab);
            instance.transform.position = transform.position;
            instance.transform.rotation = transform.rotation;
        }
    }
}
