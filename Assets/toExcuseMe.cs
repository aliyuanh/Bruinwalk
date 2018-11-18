using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toExcuseMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(wait());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            SceneManager.LoadScene("excuseMe");
        }

    }
    IEnumerator wait()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("excuseMe");

    }

}
