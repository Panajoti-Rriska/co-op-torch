﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Animator CharacterAnimator;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        if (x != 0 || z != 0)
            CharacterAnimator.SetBool("IsWalking", true);
        else
            CharacterAnimator.SetBool("IsWalking", false);

        if(Input.GetKeyDown("space"))
        {
            Debug.Log("hahahahaha");
        }

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

    }
}
