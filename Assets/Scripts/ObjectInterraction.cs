using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInterraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
	}
}
