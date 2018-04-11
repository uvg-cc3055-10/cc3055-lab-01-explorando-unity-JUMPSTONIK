using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    public float forwardSpeed = 2f;
    public Rigidbody2D bird;
    public GameObject cam;
    public bool dead = false;
    // Use this for initialization
    void Start () {
        bird = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if(dead == false && bird.transform.position.x <= 30) { 
            if (Input.GetButtonDown("Jump"))
            {
                //bird.velocity = Vector2.zero;
                bird.AddForce(Vector2.up * jumpForce);
            }
            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            bird.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }
}
