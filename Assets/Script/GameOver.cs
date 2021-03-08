using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    bool gameOver;
    public PlayerMovment playerMovment;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = true;
        playerMovment.Lose();
    }

    public void Retry()
    {
        gameOver = false;
    }
}
