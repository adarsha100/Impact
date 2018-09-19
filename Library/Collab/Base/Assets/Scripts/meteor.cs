using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour {
    [SerializeField]
    float fallingSpeed = .2f;
    Vector3 move = new Vector3(0, -.4f, 0);

	// Use this for initialization
	void Start () {
        //this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -fallingSpeed, 0);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        ((player) GameObject.FindGameObjectWithTag("Player").GetComponent<player>()).IncrementScore();
    }

    private void FixedUpdate()
    {
        this.gameObject.transform.position += move;
    }



}
