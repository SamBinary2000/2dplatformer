﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


	void Start () {
		
	}

	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {
			//Increase Score
			Destroy (gameObject);
		}
	}
}