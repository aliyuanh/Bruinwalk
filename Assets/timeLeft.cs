using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeLeft : MonoBehaviour {
    public Text text;
    public GameObject player;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = "wow";
	}
	void FixedUpdate()
    {
        text.text = player.GetComponent<playerMovement>().timeLeft.ToString("F2");
    }
}
