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
    /*
    public const int maximumHealth = 100;
    public float health;
    public UIimage healthb;
    public RectTransform healthBar;
*/
    public float stamina; //current progress

    /*
         public Vector2 pos = new Vector2(20,40);
         public Vector2 size = new Vector2(100,20);
         public Texture2D emptyTex;
         public Texture2D fullTex;
    */
    public List<AudioClip> myAudioClipsList = new List<AudioClip>();

    AudioSource sounds;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        timeLeft = 30.0f;
        stamina = 100f;

        // GetComponent<AudioSource> ().playOnAwake = false;
        //GetComponent<AudioSource> ().clip = doot;
    }

/*
     void OnGUI() {
         //draw the background:
         GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
             GUI.Box(new Rect(0,0, size.x, size.y), emptyTex);
         
             //draw the filled-in part:
             GUI.BeginGroup(new Rect(0,0, size.x * health, size.y));
                 GUI.Box(new Rect(0,0, size.x, size.y), fullTex, progress_full);
        GUI.EndGroup();
        GUI.EndGroup();
     }*/
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
       //Debug.Log("Countdown: " + timeLeft);
        
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

        //Debug.Log("Collide");
        if(col.gameObject.tag == "Opponent")
        {
            Destroy (col.gameObject, 0.5f);
            stamina -= DAMAGE;
            Debug.Log("Stamina!! reduced to " + stamina);
            transform.GetComponent<AudioSource>().clip = myAudioClipsList[Random.Range(0, 4)];
            transform.GetComponent<AudioSource>().Play();
            //healthBar.sizeDelta = new Vector2(health, healthBar.sizeDelta.y); //placement??
            if (stamina < 0)
            {
                //Death Scene pls
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
