using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Energy is given to any game object. When a game object has energy, it can perfom many actions to the environment.A player's energy 
 * consists of the following parameters, hunger, stanima, activity, and ailement. Each parameter can affect energy either positively or 
 * negatively or both. These parameters determine the value of totalEnergy which is the game object's total amount of energy available 
 * in itself. 
 */
public class Energy : MonoBehaviour
{
    public Dictionary<string, int> energyRelianceDictionary;

    // Sets default energy values to player
    public Energy()
    {
        energyRelianceDictionary = new Dictionary<string, int>();
        energyRelianceDictionary.Add("hunger", 0);
        energyRelianceDictionary.Add("stanima", 50);
        energyRelianceDictionary.Add("activity", 200);
        energyRelianceDictionary.Add("ailment", 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the player is performing an activity, update energyRelianceDictionary
        // to know what the player is doing, we'll create another dictionary listing every action the player can perform, for now, moving


    }
}
