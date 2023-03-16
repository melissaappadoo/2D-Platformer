using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameManager GameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager = FindObjectOfType<GameManager>();
            GameManager.StartCoroutine(GameManager.RespawnPlayer());
        }
    }
}
