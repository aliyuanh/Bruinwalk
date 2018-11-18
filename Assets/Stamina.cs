using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour {

	public GameObject player;
	// Use this for initialization

	public Slider Slider;

	void Start () {
		Slider = GetComponent<Slider>();
	}

	// Update is called once per frame
	void Update () {
		Slider.value = player.GetComponent<playerMovement>().stamina/100;
	}
}
