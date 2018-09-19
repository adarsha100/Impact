using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endgame : MonoBehaviour
{
    [SerializeField]
    public Text scoreText;

    // Use this for initialization
    void Start () {
        scoreText.text = "Final Score: " + player.score;
	}
}
