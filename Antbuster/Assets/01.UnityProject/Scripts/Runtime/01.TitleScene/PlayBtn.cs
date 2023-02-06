using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtn : MonoBehaviour
{
    //! 플레이 버튼을 눌렀을 때 플레이 씬으로 넘어간다
    public void OnPlayButton()
    {
        GFunc.LoadScene(GData.SCENE_NAME_PLAY);
    }   //  OnPlayButton()
}
