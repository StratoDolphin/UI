using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthFaceCamera : MonoBehaviour {

	//Since there will only be one camera, we can make this private and get the component
	public Camera targetCamera;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt (targetCamera.transform);
	}
}
