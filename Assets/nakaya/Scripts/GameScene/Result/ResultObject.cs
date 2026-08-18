using UnityEngine;

public class ResultObject : MonoBehaviour
{
    [SerializeField]
    ResultOnClick resultOnClick;
    [SerializeField]
    GameObject obj;

    [SerializeField]
    SystemManager systemManager;
    public void BattleEnd(int winnerNo)
    {
        OnBattle.Battle = false;
        obj.SetActive(true);
        ObjManager objManager = GameObject.Find("ObjManager").GetComponent<ObjManager>();
        for (int i = systemManager.hpBarManager.hpBars.Count - 1; i >= 0; --i)
        {
            systemManager.hpBarManager.RemoveHpBar(i);
        }
        resultOnClick.SetWinner(winnerNo);
        objManager.ClearMonsterObj();
    }
}