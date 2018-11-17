using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    private Vector3 offset;
    public GameObject player;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        transform.position = player.transform.position + offset;
    }

}
