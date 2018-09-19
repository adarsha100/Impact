using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("meteor"))
        {
            int x = (int)this.gameObject.transform.position.x / 4;
            int y = (int)this.gameObject.transform.position.y / -4;
            if (startup.groundObjects[y][x] != null)
                Destroy(startup.groundObjects[y][x]);
            if (y < startup.groundObjects.Length && startup.groundObjects[y + 1][x] != null)
                Destroy(startup.groundObjects[y + 1][x]);
            if (x < startup.groundObjects[y].Length && startup.groundObjects[y][x + 1] != null)
                Destroy(startup.groundObjects[y][x + 1]);
            if (x > 0 && startup.groundObjects[y][x - 1] != null)
                Destroy(startup.groundObjects[y][x - 1]);
            if (x < startup.groundObjects[y].Length && y > 0 && startup.groundObjects[y-1][x + 1] != null)
                Destroy(startup.groundObjects[y - 1][x + 1]);
            if (x > 0 && y > 0 && startup.groundObjects[y-1][x - 1] != null)
                Destroy(startup.groundObjects[y - 1][x - 1]);
            if (x < startup.groundObjects[y].Length && y > 1 && startup.groundObjects[y - 2][x + 1] != null)
                Destroy(startup.groundObjects[y - 2][x + 1]);
            if (x > 0 && y > 1 && startup.groundObjects[y - 2][x - 1] != null)
                Destroy(startup.groundObjects[y - 2][x - 1]);
        }
    }
}
