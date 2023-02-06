using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBtn : MonoBehaviour
{
    //! Exit 버튼을 눌렀을 때 부를 함수
    public void OnExitButton()
    {
        GFunc.QuitThisGame();
    }   //  OnExitButton()
}
