using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSingletone<T> : GComponent where T : GSingletone<T>
{
    private static T _instance = default;

    public static T Instance
    {
        get
        {
            if (GSingletone<T>._instance == default || _instance == default)
            {
                GSingletone<T>._instance = GFunc.CreateObj<T>(typeof(T).ToString());
                DontDestroyOnLoad(_instance.gameObject);
            }   //  if : 인스턴스가 비어 있을 때 새로 인스턴스화 한다.

            //  여기서 부터는 인스턴스가 절대 비어있지 않음
            return _instance;
        }
    }

    public override void Awake()
    {
        base.Awake();
    }   //  Awake()

    public void Creat()
    {
        this.Init();
    }   //  Creat()

    protected virtual void Init()
    {
        /* Do Something */
    }   //  Init()
}
