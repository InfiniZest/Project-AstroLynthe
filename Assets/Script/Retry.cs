using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public GameObject gameOver;
    public void RetryGame()
    {
        gameOver.SetActive(false);
        gameOver.SendMessage("Retry");
        SceneManager.LoadScene("Maze");
    }
}
