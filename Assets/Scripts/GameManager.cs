using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 
 * GameManager performs the menu, save, load states for the game
 */
public class GameManager : MonoBehaviour
{
    private bool isGameOver;

    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        set
        {
            if(value == true)
            {
                // Show something to state the player's game over
            }
            isGameOver = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if player does an action, add it to the list
    }
}
