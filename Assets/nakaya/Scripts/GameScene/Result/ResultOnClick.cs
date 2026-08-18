using System.Collections;
using UnityEngine;

public class ResultOnClick : MonoBehaviour
{
    [Header("0 = 負け、1 = 勝ち")][SerializeField]
    GameObject[] resultObjects = new GameObject[2];
    BetManager betManager;

    [Header("シーン移動までの時間")][SerializeField]
    float waitTime = 2f;

    private bool clicked = false;

    /// <summary>
    /// 0 = 負け1 = 勝ち
    /// </summary>
    private int result;
    private void Awake()
    {
        GamblingManager gambling = GameObject.Find("GamblingManager").GetComponent<GamblingManager>();
        betManager = gambling.betManager;
    }
    /// <summary>
    /// 勝者番号を受け取って勝敗を決める
    /// </summary>
    public void SetWinner(int winnerNo)
    {
        if (winnerNo == betManager.betno)
        {
            result = 1;
        }
        else
        {
            result = 0;
        }
    }

    private void OnMouseDown()
    {
        if (clicked)
            return;

        clicked = true;

        // 勝敗に応じたオブジェクトを表示
        if (resultObjects[result] != null)
        {
            resultObjects[result].SetActive(true);
        }

        StartCoroutine(MoveScene());
    }

    private IEnumerator MoveScene()
    {
        yield return new WaitForSeconds(waitTime);

        // 勝ったときだけ払い戻し
        if (result == 1)
        {
            GoldManager.gold += betManager.ReturnGold();
        }

        SceneChanger.SceneLoaded();
    }
}