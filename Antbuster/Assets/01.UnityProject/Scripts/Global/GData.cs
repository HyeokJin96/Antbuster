using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class GData
{
    public const string SCENE_NAME_TITLE = "01.TitleScene";
    public const string SCENE_NAME_PLAY = "02.PlayScene";

    public static bool isGameStart = default;
    public static bool isPlay = default;
    public static bool isGameOver = default;
    public static bool isAttacked = default;

    public static string CANON_NAME = "Canon";

    public static string ENEMY = "Ant";
    public static int ENEMY_HP = default;

    public static int points = default;
    public static int money = default;
    public static int level = default;
}
