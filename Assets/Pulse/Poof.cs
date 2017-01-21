using UnityEngine;
using System.Collections;

public class Poof : MonoBehaviour
{
    public float velocity = 30f;
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        transform.position += Vector3.right * velocity * Time.deltaTime;

        if (timer > 2f)
        {
            Destroy(gameObject);
        }
    }
}