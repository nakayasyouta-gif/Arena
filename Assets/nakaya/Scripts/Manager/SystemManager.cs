using UnityEngine;

public class SystemManager : MonoBehaviour
{
    public HpCalculator hpCalculator { get; private set; }
    public MonsterAct monsterAct { get; private set; }
    public MonsterCheck monsterCheck { get; private set; }

    public MonsterManager monsterManager {  get; private set;}
    public GamblingManager gamblingManager {get; private set;}
    [SerializeField]
    public DamageTextManager damageTextManager;
    [field:SerializeField]
    public HpBarManager hpBarManager { get; private set; }
    [SerializeField]
    ResultObject resultObject;


    public void Awake()
    {
        monsterManager = GameObject.Find("MonsterManager").GetComponent<MonsterManager>();
       gamblingManager = GameObject.Find("GamblingManager").GetComponent<GamblingManager>();
        monsterCheck = new MonsterCheck(monsterManager,gamblingManager.betManager,resultObject);

        hpCalculator = new HpCalculator( monsterManager,monsterCheck,damageTextManager,hpBarManager);

        monsterAct = new MonsterAct( monsterManager, hpCalculator);
    }
}