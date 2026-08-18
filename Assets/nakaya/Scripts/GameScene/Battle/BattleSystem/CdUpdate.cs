using UnityEngine;

public class CdUpdate : MonoBehaviour
{
    [SerializeField]
    SystemManager systemManager;
    MonsterAct monsterAct { get; set; }

    [SerializeField]
    ObjMove objMove;
    private void Start()
    {
        monsterAct = systemManager.monsterAct;
    }
    void Update()
    {
        if (monsterAct == null||!OnBattle.Battle) return;
        monsterAct.CountCd();
        for (int i = 0; i < monsterAct.actcds.Count; i++)
        {
            float cd = monsterAct.actcds[i];

            if (cd <= 0)
            {
                objMove.MoveObj(i);
                monsterAct.ResetActcd(i);
            }
        }
    }
}
