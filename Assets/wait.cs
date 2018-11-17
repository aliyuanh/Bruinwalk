using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wait : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(waitThing());
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
    IEnumerator waitThing()
    {
        yield return new WaitForSeconds(.1f);

    }
}