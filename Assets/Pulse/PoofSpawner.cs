using UnityEngine;
using System.Collections;

public class PoofSpawner : MonoBehaviour
{
    public GameObject poofPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SpawnPoof();
            Invoke("SpawnPoof", 0.15f);
        }
    }

    void SpawnPoof()
    {

        GameObject instance = Instantiate(poofPrefab);
        instance.transform.position = transform.position;
        instance.transform.rotation = transform.rotation;
    }
}
