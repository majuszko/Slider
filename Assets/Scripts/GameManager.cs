using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    public Text txt;
    public Text scoreText;
    public int score;
    public Text highScoreText;
    public Text title;

    private void Awake()
    {
        highScoreText.text = "Highscore: " + GetScore().ToString();
    }

    public void StartGame()
    {
        gameStarted = true;
        FindObjectOfType<trail>().BuildingCubes();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
            txt.gameObject.SetActive(false);
            title.gameObject.SetActive(false);
            scoreText.gameObject.SetActive(true);
            highScoreText.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameOver");
        }

    }
    public void ScoreAdd()
    {
        score++;
        scoreText.text = score.ToString();
        if (score > GetScore())
        {
            PlayerPrefs.SetInt("Highscore", score);
            highScoreText.text = "Highscore: " + score.ToString();
        }
    }
    public int GetScore()
    {
        int i = PlayerPrefs.GetInt("Highscore");
        return i;
    }
    
}
