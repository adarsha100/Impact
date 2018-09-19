using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        GameObject.FindGameObjectWithTag("MainCamera").gameObject.transform.position = new Vector3(0, GameObject.FindGameObjectWithTag("Player").gameObject.transform.position.y, 10);

    }
}
