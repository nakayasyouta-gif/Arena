using UnityEngine;

public class CdUpdate : MonoBehaviour
{
    [SerializeField]
    SystemManager systemManager;
    MonsterAct monsterAct { get; set; }

    [SerializeField]
    PosSetter posSetter;
    private void Start()
    {
        monsterAct = systemManager.monsterAct;
    }
    void Update()
    {
        if (monsterAct == null||!OnBattleBool.onbattle) return;
        monsterAct.CountCd();
        for (int i = 0; i < monsterAct.actcds.Count; i++)
        {
            float cd = monsterAct.actcds[i];

            if (cd <= 0)
            {
                posSetter.MoveObj(i);
                monsterAct.ResetActcd(i);
            }
        }
    }
}
