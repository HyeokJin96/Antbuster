using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text startTimer = default;


    private float time = default;

    // Start is called before the first frame update
    void Start()
    {
        GData.isGameStart = false;
        startTimer.gameObject.SetActive(true);

        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Timer()
    {
        time = 10f;

        while (time > 0)
        {
            time -= 1;
            startTimer.text = time.ToString("0");
            yield return new WaitForSeconds(1f);

            if (time == 0)
            {
                startTimer.gameObject.SetActive(false);
                GData.isGameStart = true;
            }
        }

    }
}
