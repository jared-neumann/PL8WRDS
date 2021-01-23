using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearGameMode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("mode", "");
    }
}
