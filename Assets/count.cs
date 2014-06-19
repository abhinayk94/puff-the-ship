using UnityEngine;
using System.Collections;

public class count : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.guiText.text = inflate.count.ToString();
	}
}
