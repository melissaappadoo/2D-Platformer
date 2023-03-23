using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthDisplay : MonoBehaviour
{
    public int health = 5;
    public TMP_Text healthText;

    private void Update()
    {
        healthText.text = "X " + health.ToString();
    }
}
