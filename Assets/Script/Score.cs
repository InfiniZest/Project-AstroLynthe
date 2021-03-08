using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI scoreText;
    int score;
    int highScore;
    bool hasPuddle;
    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        hasPuddle = false;
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateScore();
    }

    public void AddScore(int x)
    {
        score += x;
        UpdateScore();
    }

    public int HighScore
    {
        get
        {
            return highScore;
        }
    }

    void UpdateScore()
    {
        scoreText.text = score + "";
    }

    void onGameOver()
    {
        if(score > HighScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    public void puddleGet()
    {
        hasPuddle = true;
    }

    public void removePuddle()
    {
        hasPuddle = false;
    }
    public bool puddleCheck()
    {
        return hasPuddle;
    }
}
