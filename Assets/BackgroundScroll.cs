using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundScroll : MonoBehaviour
{

    public float scrollSpeed;
    public List<GameObject> bg_pieces;
    Vector3 startPos;
    
    void Start()
    {
        if(bg_pieces == null || bg_pieces.Count == 0)
        {
            print("bg scroller needs bg_piece referenses");
            Destroy(gameObject);
        }

        startPos = bg_pieces[0].transform.position;
    }

    void Update()
    {
        transform.position -= Vector3.right * scrollSpeed * Time.deltaTime;

        if (bg_pieces[1].transform.position.x <= startPos.x)
        {
            float distance = Mathf.Abs((startPos - bg_pieces[0].transform.position).magnitude);
            Vector3 newPos = transform.position;
            newPos.x += distance;
            transform.position = newPos;
        }
    }
}