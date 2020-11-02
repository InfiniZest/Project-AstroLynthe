using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Animator playerAinmation;
    public PlayerStats playerStats;
    public Queue<int> playerActions;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        IsPlayerMoving();
        // isPlayerInteracting();
        // is player leaving scene?

    }
     
    private bool IsPlayerMoving()
    {
        // Is the player in the Hub scene?
        if (SceneManager.GetActiveScene().name== "Hub")
        {
            playerAinmation.SetBool("isMoving", false);
            float horizontalInput = Input.GetAxis("Horizontal");
            if (horizontalInput > 0 || horizontalInput < 0)
            {
                playerAinmation.SetBool("isMoving", true);
                transform.Translate(new Vector2(horizontalInput, 0) * 5 * Time.deltaTime);
                return true;
            }
        }
        return false;

    }

}
