using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this script is supposed to exclusively be called by the Quit button *through* the SceneManager empty gameobject
public class QuitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //when clicked, close game
    public void onClick()
    {
        Debug.Log("Closing game"); //test code
        Application.Quit();
    }
}
