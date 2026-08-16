using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public HpCalculator hpCalculator { get; private set; }
    public MonsterAct monsterAct { get; private set; }
    public MonsterCheck monsterCheck { get; private set; }

    [SerializeField]
    public MonsterManager monsterManager;
    [SerializeField]
    public DamageTextManager damageTextManager;
    [SerializeField]
    public HpBarManager hpBarManager;


    public void Initialize()
    {
        monsterCheck = new MonsterCheck(monsterManager);

        hpCalculator = new HpCalculator( monsterManager,monsterCheck,damageTextManager,hpBarManager);

        monsterAct = new MonsterAct( monsterManager, hpCalculator);
    }
}