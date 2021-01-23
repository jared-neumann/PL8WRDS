using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{

    public void Mode_1MN()
    {
        PlayerPrefs.SetString("mode", "1MN");
    }

    public void Mode_3MN()
    {
        PlayerPrefs.SetString("mode", "3MN");
    }

    public void Mode_INF()
    {
        PlayerPrefs.SetString("mode", "INF");
    }

}
