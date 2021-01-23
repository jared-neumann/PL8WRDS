using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public TMP_Text timer;
    float timeStart;
    public TMP_Text instructions;
    public TMP_Text prompt;
    public TMP_InputField score;
    public GameObject gameover;
    public GameObject keyboard;
    public GameObject input;
    public static int scoreRate;
    public TMP_Text pauseRateText;
    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetString("mode") == "1MN")
            timeStart = 60;
        if (PlayerPrefs.GetString("mode") == "3MN")
            timeStart = 180;
        if (PlayerPrefs.GetString("mode") == "INF")
            timeStart = 0;

            timer.text = timeStart.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (!(PlayerPrefs.GetString("mode") == "INF"))
        {
            if (instructions.text == "")
            {
                timeStart -= Time.deltaTime;
                timer.text = timeStart.ToString("0");
            }
            if (timeStart <= 0)
            {
                instructions.text = "GME OVR";
                prompt.text = "";
                gameover.SetActive(true);
                keyboard.SetActive(false);
                input.SetActive(false);

                if (PlayerPrefs.GetString("mode") == "1MN")
                {
                    if (PlayerPrefs.GetInt("score_1MN") < Convert.ToInt32(score.text))
                    {
                        PlayerPrefs.SetInt("score_1MN", Convert.ToInt32(score.text));
                    }
                }

                if (PlayerPrefs.GetString("mode") == "3MN")
                {
                    if (PlayerPrefs.GetInt("score_3MN") < Convert.ToInt32(score.text))
                    {
                        PlayerPrefs.SetInt("score_3MN", Convert.ToInt32(score.text));
                    }
                }

            }           
        }
        
        if (PlayerPrefs.GetString("mode") == "INF")
        {
            if (instructions.text == "")
            {
                timeStart += Time.deltaTime;
                timer.text = timeStart.ToString("0");


            }

            if (PlayerPrefs.GetInt("score_INF") < Convert.ToInt32(score.text))
            {
                PlayerPrefs.SetInt("score_INF", Convert.ToInt32(score.text));
            }

            //if (PlayerPrefs.GetInt("timer_INF") < Convert.ToInt32(timeStart))
            //{
            //    PlayerPrefs.SetInt("timer_INF", Convert.ToInt32(timeStart));
            //}

            if (timeStart >= 1 && PauseGame.pause % 2 == 0)
            {
                scoreRate = Convert.ToInt32(Convert.ToInt32(score.text)/(timeStart / 60));
                pauseRateText.text = "Average Score Rate Per Minute:\n" + Timer.scoreRate.ToString();
                Debug.Log(scoreRate);

                if (PlayerPrefs.GetInt("rate_INF") < scoreRate)
                {
                    PlayerPrefs.SetInt("rate_INF", scoreRate);
                }

            }
            

        }

    }
}
