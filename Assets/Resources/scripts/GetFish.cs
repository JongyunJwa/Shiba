using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFish : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D fish)
    {
        if(fish.gameObject.name == "Fish")
        {
            GameObject.Find("GameManager").SendMessage("CountUpFish");
            Destroy(fish.gameObject);
        }

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
