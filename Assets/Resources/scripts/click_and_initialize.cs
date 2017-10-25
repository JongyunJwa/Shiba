using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class click_and_initialize : MonoBehaviour {

    public Sprite[] spriteImg;
    

    // Use this for initialization
    void Start () {
           
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            //GetComponent<SpriteRenderer>().sprite = spriteImg[0];
            gameObject.GetComponent<Image>().sprite = spriteImg[0];
            Debug.Log("바껴라좀ㅅ");
        }


    }

}
 
    