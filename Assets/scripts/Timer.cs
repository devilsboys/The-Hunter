using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float delay = 0.1f;
    public Slider timeSlider;
    private int counter = 0;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SliderTimer", 1.0f, 0.1f);
        //StartCoroutine(OnAttack());
        //Rect healthBarRect = new Rect(0f, 0f, 0.5f * Screen.width, 0.05f * Screen.height);
	}
/*
    IEnumerator OnAttack()
    {
        //Debug.Log("onAttack");
        yield return new WaitForSeconds(delay);
        Count();
        StartCoroutine(OnAttack());
    }

    void Count()
    {
        if (counter <= 100)
        {
            timeSlider.value = counter;
            counter++;
        }
    }
*/
	
	// Update is called once per frame
	void Update () {
	    
	}
    void SliderTimer()
    {
        if (counter <= 100)
        {
            timeSlider.value = counter;
            counter++;

        }
        else
        {
            CancelInvoke("SliderTimer");
            
        }
       // Debug.Log("time:"+counter);
    }
}
