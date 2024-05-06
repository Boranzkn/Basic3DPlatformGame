using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerController playerController;
    bool isGameEnded = false;
    int score = 0;
    [SerializeField] TMP_Text scoreText;

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

    public void AddScore(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }
}
