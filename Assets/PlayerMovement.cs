using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public Vector2 jump = new Vector2(0, 300);
    Rigidbody2D rigi;
	
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown
            ("space"))
        {
            rigi.velocity = Vector2.zero;
            rigi.AddForce(jump);
        }
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
    
}