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
        Vector3 pos = this.gameObject.transform.position;
        Destroy(this.gameObject);
        player player = ((player)GameObject.FindGameObjectWithTag("Player").GetComponent<player>());

        if (collision.gameObject.tag.Equals("Player"))
        {
            player.loseGame();
            return;
        }

        // check if player is in explosion range, if so kill him
        float rightEdgePlayer = player.transform.position.x + 4;
        float leftEdgePlayer = player.transform.position.x;
        if ((rightEdgePlayer >= pos.x - 3 && rightEdgePlayer <= pos.x + 7)
            || (leftEdgePlayer >= pos.x - 3 && leftEdgePlayer <= pos.x + 7))
        {
            float topEdgePlayer = player.transform.position.y;
            float botEdgePlayer = player.transform.position.y - 4;
            if ((topEdgePlayer <= pos.y + 3 && topEdgePlayer >= pos.y - 3)
                || (botEdgePlayer <= pos.y + 3 && botEdgePlayer >= pos.y - 3))
            {
                player.loseGame();
                return;
            }
        }

        player.IncrementScore();
    }

    private void FixedUpdate()
    {
        this.gameObject.transform.position += move;
    }

}
