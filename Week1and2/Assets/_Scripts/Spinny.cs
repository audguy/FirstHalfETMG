﻿using UnityEngine;
using System.Collections;

public class Spinny : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward, 100.0f * Time.deltaTime);
	}
}
