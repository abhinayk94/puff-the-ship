using UnityEngine;
using System.Collections;

public class transition : MonoBehaviour {

	// Use this for initialization
	public double i;
	void Start () {
		while (i < 500009001) {
			i=i+1;
				}
		Application.LoadLevel ("scene0");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
