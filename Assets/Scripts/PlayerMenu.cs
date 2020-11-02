using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenu : MonoBehaviour
{
    public GameObject playerMenu;

    private void Start()
    {
        PlayerOnMenu = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(playerMenu.activeSelf);
        if (PlayerOnMenu)
        {
            // If player presses resume button
            if(playerMenu.activeSelf)
            {
                PlayerOnMenu = false;
            }
        }
    }

    /* TODO: Remap controls where player cannot move character and can only 
    interact with the menu with either keyboard or mouse using GameManager method*/
    private bool PlayerOnMenu
    {
        get
        {
            if (Input.GetKeyDown(KeyCode.Escape) && !playerMenu.activeSelf)
            {
                playerMenu.SetActive(true);
                print("Menu Enabled");
                // Disable player control and enable menu control using boolean param to determine this
                return true;
            }
            else
                return false;
        }
        set
        {
            playerMenu.SetActive(value);
            // Enable or Disable player control or menu control using 'value' to determine this
        }
    }
}
