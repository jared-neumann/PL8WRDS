using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;

public class Ads : MonoBehaviour
{
    readonly string gameID_Google = "3760843";
    public bool testMode = true;

    void Start()
    {
        Advertisement.Initialize(gameID_Google, testMode);
        StartCoroutine(ShowBannerWhenReady());

    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady())
        {
            yield return new WaitForSeconds(0.5f);
        }

        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show();
        
    }

    void OnDestroy()
    {
        Advertisement.Banner.Hide();
    }

}
