using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seaweedGrow : MonoBehaviour {
    public Sprite[] spriteImg;

    int spriteIdx = 0;

	// Use this for initialization
	void Start () {
        InvokeRepeating("ChangeSprite", 0.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    void ChangeSprite()
    {
        if (spriteIdx == 2)
            GetComponent<SpriteRenderer>().sprite = spriteImg[2];

        //spriteIdx %= spriteImg.Length;
        else { 
            GetComponent<SpriteRenderer>().sprite = spriteImg[spriteIdx];
            ++spriteIdx;
        }

    }
}
