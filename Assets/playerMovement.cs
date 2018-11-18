using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour {
    Rigidbody rb;
    public float speed;
    public float timeLeft;
    public const int DAMAGE = 10;
    public float stamina; //current progress


    public List<AudioClip> myAudioClipsList = new List<AudioClip>();

    AudioSource sounds;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        timeLeft = 30.0f;
        stamina = 100f;
    }


	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
       //Debug.Log("Countdown: " + timeLeft);

        if(timeLeft < 0)
        {
            SceneManager.LoadScene("death");
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

        //Debug.Log("Collide");
        if(col.gameObject.tag == "Opponent")
        {
            Destroy (col.gameObject, 0.5f);
            stamina -= DAMAGE;
            Debug.Log("Stamina!! reduced to " + stamina);
            transform.GetComponent<AudioSource>().clip = myAudioClipsList[Random.Range(0, 4)];
            transform.GetComponent<AudioSource>().Play();
            if (stamina < 0)
            {
                SceneManager.LoadScene("death");
            }
           // GetComponent<AudioSource> ().Play ();
        }

        if(col.gameObject.tag == "Moore")
        {
            Debug.Log("moore hit");
            SceneManager.LoadScene("calpirg");
        }


    }


}
