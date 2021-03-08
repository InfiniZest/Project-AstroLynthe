using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject prefab;
    public CountdownTimer countdownTimer;
    public TextMeshProUGUI floatingText;
    public LoadAssets geyserAssets;
    public LoadAssets puddleAssets;
    public void DoInteraction()
    {
        if (gameObject.name.Contains("geyser"))
        {
            replace();
            int randInt = Random.Range(8, 12);
            Debug.Log(countdownTimer.timer + randInt);
            countdownTimer.timer = (countdownTimer.timer + randInt > 44) ? 45 : countdownTimer.timer + randInt;
            Debug.Log(countdownTimer.timer);
        }
        else if (gameObject.name.Contains("puddle"))
        {
            replace();
            Score.instance.puddleGet();
            Score.instance.AddScore(1);
            floatingText.text = "Water get!";
        }
        else if (gameObject.name.Contains("Ladder"))
        {
            if (Score.instance.puddleCheck())
            {
                Score.instance.AddScore(1);
                Score.instance.removePuddle();
                floatingText.text = "Nice!";
                geyserAssets.SendMessage("Randomize");
                puddleAssets.SendMessage("Randomize");
                geyserAssets.SendMessage("DestroyAll");
               

            }
            else
            {
                Debug.Log("No!");          
                floatingText.text = "Puddling Missing!";
            }
        }
    }

    void replace()
    {
        gameObject.SetActive(false);
        GameObject empty = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        empty.transform.parent = GameObject.Find("Empty").transform;
        prefab.SetActive(true);
    }
}
