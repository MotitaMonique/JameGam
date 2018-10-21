using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakingRange : MonoBehaviour {

    public GameObject dragonProbably;
    public GameObject npcProbably;

    public Canvas textCanvas;

    private bool displaySpeech;

	// Use this for initialization
	void Start () {
        displaySpeech = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(CollisionForSpeaking(dragonProbably,npcProbably) == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                displaySpeech = true;
            }
        }

        if(displaySpeech == true)
        {
            Conversation();
        }
	}


    public bool CollisionForSpeaking(GameObject ow, GameObject otherOw)
    {
        Collider owCollider = ow.GetComponent<Collider>();

        Collider otherOwCollider = otherOw.GetComponent<Collider>();


        if (owCollider.bounds.Intersects(otherOwCollider.bounds))
        {

            return true;
        }
        else
        {
            return false;
        }
    }

    public void Conversation()
    {

    }
}
