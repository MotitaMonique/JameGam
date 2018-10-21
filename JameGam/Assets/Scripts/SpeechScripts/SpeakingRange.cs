using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeakingRange : MonoBehaviour
{

    public GameObject dragonProbably;

    public GameObject tempObj;

    public List<GameObject> picnicPeople;

    public GameObject goalPerson;

    public Canvas textCanvas;



    // Use this for initialization
    void Start()
    {
        tempObj = GameObject.Find("PeopleSpawner");

        picnicPeople = tempObj.GetComponent<SpawnPeople>().people;


    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < picnicPeople.Count; i++)
        {
            if ((CollisionForSpeaking(dragonProbably, picnicPeople[i]) == true) &&
                (Input.GetKeyDown(KeyCode.E)))
            {

                SceneManager.LoadScene("MainGame");
            }
        }

        if ((CollisionForSpeaking(dragonProbably, goalPerson) == true) &&
                (Input.GetKeyDown(KeyCode.E)))
        {

            Application.Quit();
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
}
