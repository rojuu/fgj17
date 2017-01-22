using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 4;
    AudioSource point; 

	void Start ()
    {
        point = GetComponent<AudioSource>();
        GetComponent<Rigidbody2D>().velocity = velocity;
        float rand = range * Random.value;
        if (Random.value > 0.5) { rand *= -1; }
        transform.position = new Vector3(transform.position.x, transform.position.y + rand, transform.position.z);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
            point.Play();
    }
}
