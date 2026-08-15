using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public HpCalculator hpCalculator { get; private set; }
    public MonsterAct monsterAct { get; private set; }
    public MonsterCheck monsterCheck { get; private set; }

    [field: SerializeField]
    public MonsterManager monsterManager { get; private set; }

    public void Initialize()
    {
        monsterCheck = new MonsterCheck(monsterManager);

        hpCalculator = new HpCalculator( monsterManager,monsterCheck);

        monsterAct = new MonsterAct( monsterManager, hpCalculator);
    }
}