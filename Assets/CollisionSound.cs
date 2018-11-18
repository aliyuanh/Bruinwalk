using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{

    public List<AudioClip> hurtSounds = new List<AudioClip>();

    void Start()
    {
        // SoundFolder should be in Assets/Resources 
        hurtSounds.Add((AudioClip)Resources.Load("SMG4 Sound Effects - Ow, Shit!"));
        hurtSounds.Add((AudioClip)Resources.Load("The Wilhelm scream sound effect"));
        hurtSounds.Add((AudioClip)Resources.Load("The Boo! You Suck! Sound Effect - UPDATED"));
        hurtSounds.Add((AudioClip)Resources.Load("Ow!"));
        hurtSounds.Add((AudioClip)Resources.Load("Oh My Leg!"));
    }
    void Update()
    {
    }

    void OnCollisionEnter(Collision col)
    {

        Debug.Log("Collide");
        if (col.gameObject.tag == "Opponent")
        {
            transform.GetComponent<AudioSource>().clip = hurtSounds[Random.Range(0, hurtSounds.Count)];
            transform.GetComponent<AudioSource>().Play();
        }


    }
}