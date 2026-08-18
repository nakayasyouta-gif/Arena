using UnityEngine;
using AudioName;

public class AudioLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        AudioManager.Instance.LoadBGM(BGMName.LOSE_BGM_NAME, "Audio/BGM/BG_make");
        AudioManager.Instance.LoadBGM(BGMName.BATTLE_BGM_NAME, "Audio/BGM/BG_battle");
        AudioManager.Instance.LoadBGM(BGMName.WIN_BGM_NAME, "Audio/BGM/BG_win");
        AudioManager.Instance.LoadBGM(BGMName.SHOP_BGM_NAME, "Audio/BGM/BG_shop");
        AudioManager.Instance.LoadBGM(BGMName.BET_BGM_NAME, "Audio/BGM/BG_kake");

        AudioManager.Instance.LoadSE(SEName.ATTACK_SE_NAME, "Audio/SE/SE_attack");
        AudioManager.Instance.LoadSE(SEName.HIT_SE_NAME, "Audio/SE/SE_hit");
        AudioManager.Instance.LoadSE(SEName.CRITICAL_SE_NAME, "Audio/SE/SE_critical");
        AudioManager.Instance.LoadSE(SEName.GAMEEND_SE_NAME, "Audio/SE/SE_gameend");
    }

    public void Final()
    {
        AudioManager.Instance.UnloadBGM(BGMName.LOSE_BGM_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.BATTLE_BGM_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.WIN_BGM_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.SHOP_BGM_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.BET_BGM_NAME);

        AudioManager.Instance.UnloadSE(SEName.ATTACK_SE_NAME);
        AudioManager.Instance.UnloadSE(SEName.HIT_SE_NAME);
        AudioManager.Instance.UnloadSE(SEName.CRITICAL_SE_NAME);
        AudioManager.Instance.UnloadSE(SEName.GAMEEND_SE_NAME);
    }
}

namespace AudioName
{
    public static class BGMName
    {
        public static string BATTLE_BGM_NAME = "battle";
        public static string BET_BGM_NAME = "bet";
        public static string SHOP_BGM_NAME = "shop";
        public static string WIN_BGM_NAME = "win";
        public static string LOSE_BGM_NAME = "lose";
    }

    public static class SEName
    {
        public static string ATTACK_SE_NAME = "attack";
        public static string CRITICAL_SE_NAME = "critical";
        public static string GAMEEND_SE_NAME = "gameend";
        public static string HIT_SE_NAME = "hit";
    }
}