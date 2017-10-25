using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    static public int characterIdx;
    public GameObject character;

	// Use this for initialization
	void Start () {
        Instantiate(character);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
