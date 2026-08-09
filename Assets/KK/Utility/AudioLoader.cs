using UnityEngine;
using AudioName;

public class AudioLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        AudioManager.Instance.LoadBGM(BGMName.GAMESTART_BGM_NAME, "Audio/BGM/LVSD-0006_07_DespairsDawn-full_loop");
        AudioManager.Instance.LoadBGM(BGMName.CHARACTER_CHOICE_BGM_NAME, "Audio/BGM/LVSD-0006_04_SealedSanctuary_loop");
        AudioManager.Instance.LoadBGM(BGMName.NORMAL_BATTLE_BGM_NAME, "Audio/BGM/LVSD-0006_03_annulus_loop");
        AudioManager.Instance.LoadBGM(BGMName.MAP_BGM_NAME, "Audio/BGM/WAV_Bestus_loop");
        AudioManager.Instance.LoadBGM(BGMName.MIDDLE_BOSS_NAME, "Audio/BGM/LVSD-0006_02_CosmoCounter_loop");
        AudioManager.Instance.LoadBGM(BGMName.LAST_BOSS_NAME, "Audio/BGM/LVSD-0006_05_BattleAmidstTheStorm_loop");

        AudioManager.Instance.LoadSE(SEName.DAMAGE_SE_NAME, "Audio/SE/Damage");
        AudioManager.Instance.LoadSE(SEName.BUTTON_SE_NAME, "Audio/SE/Button");
        AudioManager.Instance.LoadSE(SEName.UPGRADE_SE_NAME, "Audio/SE/Upgrade");
        AudioManager.Instance.LoadSE(SEName.BACK_SE_NAME, "Audio/SE/Back");
        AudioManager.Instance.LoadSE(SEName.CONFIRM_SE_NAME, "Audio/SE/Confirm");
        AudioManager.Instance.LoadSE(SEName.GAMESTART_SE_NAME, "Audio/SE/GameStart");
    }

    public void Final()
    {
        AudioManager.Instance.UnloadBGM(BGMName.GAMESTART_BGM_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.CHARACTER_CHOICE_BGM_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.NORMAL_BATTLE_BGM_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.MAP_BGM_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.MIDDLE_BOSS_NAME);
        AudioManager.Instance.UnloadBGM(BGMName.LAST_BOSS_NAME);

        AudioManager.Instance.UnloadSE(SEName.BUTTON_SE_NAME);
        AudioManager.Instance.UnloadSE(SEName.DAMAGE_SE_NAME);
        AudioManager.Instance.UnloadSE(SEName.UPGRADE_SE_NAME);
        AudioManager.Instance.UnloadSE(SEName.BACK_SE_NAME);
        AudioManager.Instance.UnloadSE(SEName.CONFIRM_SE_NAME);
        AudioManager.Instance.UnloadSE(SEName.GAMESTART_SE_NAME);
    }
}

namespace AudioName
{
    public static class BGMName
    {
        public static string GAMESTART_BGM_NAME = "Title";
        public static string CHARACTER_CHOICE_BGM_NAME = "Character";
        public static string NORMAL_BATTLE_BGM_NAME = "NormalBattle";
        public static string MAP_BGM_NAME = "MapName";
        public static string MIDDLE_BOSS_NAME = "MiddleBoss";
        public static string LAST_BOSS_NAME = "LastBoss";
    }

    public static class SEName
    {
        public static string DAMAGE_SE_NAME = "Damage";
        public static string BUTTON_SE_NAME = "Button";
        public static string UPGRADE_SE_NAME = "Upgrade";
        public static string BACK_SE_NAME = "Back";
        public static string CONFIRM_SE_NAME = "Confirm";
        public static string GAMESTART_SE_NAME = "GameStart";
    }
}