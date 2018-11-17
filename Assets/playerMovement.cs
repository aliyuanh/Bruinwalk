using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    Rigidbody rb;
    public float speed;
    public float timeLeft = 30.0f;
    //public AudioClip doot; //add audiosource

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        timeLeft = 30.0f;
       // GetComponent<AudioSource> ().playOnAwake = false;
         //GetComponent<AudioSource> ().clip = doot;
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        Debug.Log("Countdown: " + timeLeft);
        if(timeLeft < 0)
        {
            //go to death scene
        }
		
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed);
        }else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed );
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
        }else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }


    }

    void OnCollisionEnter(Collision col)
    {

        Debug.Log("Collide");
        if(col.gameObject.tag == "Opponent")
        {
            Destroy (col.gameObject, 0.25f);

           // GetComponent<AudioSource> ().Play ();
        }


    }


}
