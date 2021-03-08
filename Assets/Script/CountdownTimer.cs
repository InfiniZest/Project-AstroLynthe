using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CountdownTimer : MonoBehaviour
{
    [SerializeField] float startTime = 20f;
    [SerializeField] TextMeshProUGUI timerText;
    public GameObject gameOver;
    // Start is called before the first frame update

    public float timer;
    void Start()
    {
        StartCoroutine(Timer());
    }
    private IEnumerator Timer()
    {
        timer = startTime;

        do
        {
            timer -= Time.deltaTime;
            FormatText();
            yield return null;
        } while (timer > 0);
        gameOver.SetActive(true);
    }

    private void FormatText()
    {
        int seconds = (int)(timer % 60);
        int milliseconds = (int)((timer - (int)timer) * 100);
        timerText.text = "";
        timerText.text += seconds + "s ";
        timerText.text += milliseconds + "ms ";
    }
}
