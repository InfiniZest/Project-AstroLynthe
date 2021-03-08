using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public PlayerMovment PlayerMovment;
    public TextMeshProUGUI floatingText;

    void Update()
    {
        if (Input.GetButtonDown("Interact") && currentInterObj && !currentInterObj.name.Contains("Empty") && PlayerMovment.IsMovable())
        {
            currentInterObj.SendMessage("DoInteraction");
        }    
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("interactable"))
        {
            currentInterObj = collision.gameObject;
            Debug.Log(this.currentInterObj.name);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("interactable"))
        {
            if(collision.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            floatingText.text = "";
        }
    }
}

