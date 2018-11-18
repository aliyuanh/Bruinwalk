using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opponentMovement : MonoBehaviour {
    public float dist = 5;
    //bool rL = (Random.value > 0.5f);
    Vector3 startPos;
    public bool startRight;
	// Use this for initialization
	void Start () {
        StartCoroutine(leftRight());
	}

    IEnumerator leftRight()
    {
        if (startRight)
        {
            for (float i = 0; i < dist; i += .05f)
            {
                transform.position += new Vector3(.03f, 0, 0);
                yield return new WaitForSeconds(.01f);
            }
            startRight = false;
        }
            for (float i = dist; i > 0; i -= .05f)
            {
                transform.position -= new Vector3(.03f, 0, 0);
                yield return new WaitForSeconds(.01f);
            }
        startRight = true;
        StartCoroutine(leftRight());
    }

}
