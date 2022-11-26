using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject endMenu;
    public TextMeshProUGUI timerText;
    private float startTime;
    private bool finnished = false;

    private void Start()
    {
        endMenu = GameObject.Find("EndMenu");
        endMenu.gameObject.SetActive(false);
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished)
            return;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f1");

        timerText.text = minutes + ":" + seconds;
    }

    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.yellow;
        endMenu.gameObject.SetActive(true);
    }
}
