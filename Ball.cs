using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;

    private bool hasStarted = false;

    private Vector3 paddleToBallVector;


	// Use this for initialization
	void Start ()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
        {
            //Lock the ball relative to paddle.
            this.transform.position = paddle.transform.position + paddleToBallVector;

            //Launches ball on click and starts the game.
            if (Input.GetMouseButtonDown(0))
            {
                


                Rigidbody2D ballBody = gameObject.GetComponent<Rigidbody2D>();
                hasStarted = true;
                ballBody.velocity = new Vector2(2f, 10f);
            }
        }
	}
}
