using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ohNoLate : MonoBehaviour {
    public float letterPause;
    string message;
    Text textComp;
	// Use this for initialization
	void Start () {
        textComp = GetComponent<Text>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
	}
	IEnumerator TypeText()
    {
        foreach(char letter in message.ToCharArray())
        {
            textComp.text += letter;
            yield return new WaitForSeconds(letterPause);
        }
    }

}
