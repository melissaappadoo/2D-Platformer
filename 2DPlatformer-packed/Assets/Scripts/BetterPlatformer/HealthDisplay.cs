using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    private int health = 5;
    public TMP_Text healthText;

    private void Update()
    {
        healthText.text = "X " + health.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            health--;
        }
    }
}
