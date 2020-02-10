using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInvisible : MonoBehaviour {

	private GameObject camera;

	// Use this for initialization
	void Start () {
		this.camera = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < camera.transform.position.z){
			Destroy(this.gameObject);
		}
	}

/*	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}*/
}
