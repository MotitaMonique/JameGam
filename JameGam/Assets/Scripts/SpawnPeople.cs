using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeople : MonoBehaviour {

    public int numberOfPeople; //how many people are spawned
    public float minHeight;
    public float maxHeight;

    public GameObject person; //person prefab
    public AudioClip[] voices; //voice clips
    public GameObject[] food; //food prefabs
    public List<Vector3> acceptableSpawns; //where can person spawn?

    
    public List<GameObject> people; //list of all the newly instantiated people

    // Use this for initialization
    void Start () {
		for(int i = 0; i < numberOfPeople; i++)
        {
            Vector3 theSpawn = acceptableSpawns[Random.Range(0, acceptableSpawns.Count)];
            acceptableSpawns.Remove(theSpawn); //remove that spawn from the list so people don't stack onto each other
            GameObject p = Instantiate(person, theSpawn, Quaternion.identity); //spawn the person somewhere
            p.transform.localScale = new Vector3(p.transform.localScale.x, Random.Range(minHeight, maxHeight), p.transform.localScale.z);
            p.GetComponent<AudioSource>().clip = voices[Random.Range(0, 3)];
            p.GetComponent<Personality>().target = false;
            people.Add(p);

            Vector3 foodPos = new Vector3(Random.Range(0.3f, 0.6f), 0.5f, Random.Range(0.3f, .6f));
            GameObject myFood = Instantiate(food[Random.Range(0, 3)], foodPos, Quaternion.identity);
            myFood.transform.position += p.transform.position;


        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddTarget(GameObject t)
    {
        people.Add(t);
    }
}
