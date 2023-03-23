using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public ScoreDisplay scoreDisplay;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            IncreaseScore();
        }
    }

    void IncreaseScore()
    {
        scoreDisplay.score = scoreDisplay.score + 100;
        Destroy(gameObject);
    }
}
