using UnityEngine;
using System.Collections;

public class Poof : MonoBehaviour
{
    bool moving;
    float velocity = 30f;
    Vector3 startPos;


    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moving = true;
        }

        if (moving)
        {
            transform.position += Vector3.right * velocity * Time.deltaTime;
        }

        if ((transform.position - startPos).magnitude > 30f)
        {
            moving = false;
            transform.position = startPos;
        }
    }
}
