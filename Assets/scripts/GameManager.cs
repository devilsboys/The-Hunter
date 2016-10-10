using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    animal animalScript;
    public GameObject animal;
    public Transform[] ranges;
    public Slider power;

	// Use this for initialization
	void Start () {
        Vector3 pos = new Vector3(Random.Range(ranges[0].position.x, ranges[1].position.x), Random.Range(ranges[2].position.y, ranges[3].position.y), 0);
        Instantiate(animal, pos, transform.rotation);
        animalScript = FindObjectOfType<animal>();
        animalScript.setRange(ranges[1].position.x, ranges[3].position.y, ranges[0].position.x, ranges[2].position.y);
	}
	
	// Update is called once per frame
	void Update () {

	}
    void box()
    {
        power.value += 1;
    }
}
