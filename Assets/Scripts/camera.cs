using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.FindGameObjectWithTag("MainCamera").gameObject.transform.position = new Vector3(80, GameObject.FindGameObjectWithTag("Player").gameObject.transform.position.y, -10);
	}
}
