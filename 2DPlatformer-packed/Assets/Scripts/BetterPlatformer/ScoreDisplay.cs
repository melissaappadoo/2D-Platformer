using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
