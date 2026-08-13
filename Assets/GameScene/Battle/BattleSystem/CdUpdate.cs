using UnityEngine;

public class CdUpdate : MonoBehaviour
{
    [SerializeField]
    SystemManager systemManager;
    MonsterAct monsterAct { get; set; }
    private void Start()
    {
        monsterAct = systemManager.monsterAct;
    }
    void Update()
    {
        if (monsterAct == null) return;
        monsterAct.CountCd();
    }
}
