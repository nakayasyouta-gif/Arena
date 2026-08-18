using UnityEngine;
using UnityEngine.SceneManagement;
using AudioName;

public class TitleButton : MonoBehaviour
{

    public void GameStart()
    {
        AudioManager.Instance.StopBGM(BGMName.BET_BGM_NAME);
        SceneManager.LoadScene("BetScene");
    }
}
