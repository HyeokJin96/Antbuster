using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Play : MonoBehaviour
{
    public void OnPlayButton()
    {
        GFunc.LoadScene(GData.SCENE_NAME_PLAY);
    }
}
