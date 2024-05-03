using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerController playerController;
    bool isGameEnded = false;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    public void RespawnPlayer()
    {
        if (!isGameEnded)
        {
            isGameEnded = true;
            StartCoroutine("RespawnCoroutine");
        }
    }

    private IEnumerator RespawnCoroutine()
    {
        playerController.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        playerController.transform.position = playerController.spawnPoint;
        playerController.gameObject.SetActive(true);
        isGameEnded = false;
    }
}
