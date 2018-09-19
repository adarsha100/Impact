using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject dino;
    Vector3 xMove = new Vector3(1f, 0f, 0f);
    Vector3 grav = new Vector3(0f, -0.8f, 0f);
    bool fall = false;
    public Sprite faceLeft;
    public Sprite faceRight;

    public static int score;
    [SerializeField]
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        dino = GameObject.FindGameObjectWithTag("Player");
        score = -1;
        IncrementScore();
    }

    public void IncrementScore()
    {
        ++score;
        scoreText.text = "Score: " + score;
    }

    public void loseGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && !fall)
        {
            dino.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 20), ForceMode2D.Impulse);
            fall = true;
        }
        
    }   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("ground"))
        {
            Vector3 contactPoint = collision.contacts[0].point;
            Vector3 center = collision.collider.bounds.center;
            if(contactPoint.y >= center.y)
                fall = false;
        }
    }


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveDino(1);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = faceRight;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MoveDino(-1);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = faceLeft;
        }

        

    }

    private void MoveDino(int n)
    {
        dino.transform.position += xMove*n;
    }
}
