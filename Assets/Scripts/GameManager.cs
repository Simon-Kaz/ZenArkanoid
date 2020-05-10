using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public int score;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI restartButton;
    public TextMeshProUGUI scoreText;
    public GameObject titleScreen;

    public void StartGame(int difficulty)
    {
        isGameActive = true;
        score = 0;

        SpawnBall();
        UpdateScore(0);

        titleScreen.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    // Create a new ball that immediately starts moving
    public void SpawnBall()
    {
        throw new NullReferenceException();
        // generate new instance of ball game object
        // add velocity
    }

}
