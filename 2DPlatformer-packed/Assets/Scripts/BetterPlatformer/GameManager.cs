using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float spawnDelay = 2f;

    public Transform playerPrefab;
    public Transform spawnPoint;
    public CinemachineVirtualCamera cam;

    public IEnumerator RespawnPlayer ()
    {
        yield return new WaitForSeconds(spawnDelay);

        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        cam.m_Follow = GameObject.FindGameObjectWithTag("Player").transform;
        /*if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }*/
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
