using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Play : MonoBehaviour
{
    public GameObject playButton = default;
    public GameObject exitButton = default;
    public GameObject loadingGuage = default;
    public Image guageGreen = default;

    void Start()
    {
        GData.isPlay = false;
        guageGreen.fillAmount = 0;
    }

    public void OnPlayButton()
    {
        loadingGuage.gameObject.SetActive(true);
        GData.isPlay = true;

        StartCoroutine(Guage());
    }

    public IEnumerator Guage()
    {
        if (GData.isPlay == true)
        {
            while (guageGreen.fillAmount < 1)
            {
                guageGreen.fillAmount += 0.05f;

                yield return new WaitForSeconds(0.1f);
            }
        }

        if (guageGreen.fillAmount == 1)
        {
            GFunc.LoadScene(GData.SCENE_NAME_PLAY);
        }
    }
}
