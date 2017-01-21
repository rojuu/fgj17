using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public Vector2 jump = new Vector2(0, 300);
    Rigidbody2D rigi;
    public float holdTime = 0;
    public float maxHoldTime = 0.2f;
	
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }
	// Update is called once per frame
	void Update ()
    {
        /* if (Input.GetKeyDown("space"))
         {
             rigi.velocity = Vector2.zero;
             rigi.AddForce(jump);
         }*/
         
        // Testing
        if (Input.GetKey(KeyCode.Space))
        {
            holdTime += Time.deltaTime;
        }
        else
        {
            if (holdTime >= maxHoldTime)
            {
                rigi.velocity = Vector2.zero;
                rigi.AddForce(jump);
            }
            else if (holdTime > 0)
            {
                rigi.velocity = Vector2.zero;
                rigi.AddForce(jump * holdTime * 5);
            }
            holdTime = 0;

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.Instance.EndGame();
        Destroy(gameObject);
    }
    
}