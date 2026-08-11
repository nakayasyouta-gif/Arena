using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterGenerate:MonoBehaviour
{
    //[SerializeField]
    BaseStatusManager statusManager;
    //[SerializeField]
    ConditionManager conditionManager;
    [SerializeField]
    MonsterManager monsterManager;
    [SerializeField]
    int GenCount=2;

    private void Start()
    {
        statusManager = GameObject.Find("BaseManagerObj").GetComponent<BaseStatusManager>();
        conditionManager = GameObject.Find("ConditionManagerObj").GetComponent<ConditionManager>();
        MonsterGeneration();
    }
    private void MonsterGeneration()
    {
        for(int i=0;i<GenCount;++i)
        {
            int monstertype = Random.Range(0, statusManager.Statuss.Length - 1);
            int conditiontype = Random.Range(0, conditionManager.conditionBonuss.Length - 1);
            monsterManager.monsters.Add(StatusGenerate.GenStatus(statusManager.Statuss[monstertype], conditionManager.conditionBonuss[conditiontype]));
        }
    }
}

