using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int fishCount = 0;
    public Text  fishText;

    void CountUpFish()
    {
        fishCount++;
        fishText.text = "고등어: " + fishCount + "마리";
        Debug.Log("고등어:" + fishCount);
    } 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
