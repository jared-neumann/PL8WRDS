using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text score_1MN;
    public TMP_Text score_3MN;
    public TMP_Text score_INF;
    public TMP_Text rate_INF;
    public TMP_Text timer_INF;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("score_1MN"))
        {
            score_1MN.text = PlayerPrefs.GetInt("score_1MN").ToString();
        }

        if (PlayerPrefs.HasKey("score_3MN"))
        {
            score_3MN.text = PlayerPrefs.GetInt("score_3MN").ToString();
        }

        if (PlayerPrefs.HasKey("score_INF"))
        {
            score_INF.text = PlayerPrefs.GetInt("score_INF").ToString();
        }

        if (PlayerPrefs.HasKey("rate_INF"))
        {
            rate_INF.text = PlayerPrefs.GetInt("rate_INF").ToString();
        }

        //if (PlayerPrefs.HasKey("timer_INF"))
        //{
        //    timer_INF.text = PlayerPrefs.GetInt("timer_INF").ToString();
        //}

    }

}
