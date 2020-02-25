using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void increaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
            collision.gameObject.SetActive(false);
        increaseScore();
    }
}
