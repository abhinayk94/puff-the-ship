﻿using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began && guiTexture.HitTest (Input.GetTouch (0).position)) {
			inflate.count = 0;
			Application.LoadLevel ("scene0");
		}

	}
}
