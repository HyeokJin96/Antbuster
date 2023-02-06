using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCreator : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.Creat();
    }   //  Awake()

    // Start is called before the first frame update
    void Start()
    {
#if DEBUG_MODE
        GFunc.LoadScene(GData.SCENE_NAME_PLAY);
#else
GFunc.LoadScene(GData.SCENE_NAME_TITLE);
#endif  //  DEBUG_MODE
    }   //  Start()
}
