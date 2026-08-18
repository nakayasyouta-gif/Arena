using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterGenerate:MonoBehaviour
{
    [SerializeField]
    BaseStatusManager statusManager;
    [SerializeField]
    ConditionManager conditionManager;
    [SerializeField]
    MonsterManager monsterManager;
    [SerializeField]
    ObjSetter objSetter;
    //[SerializeField]
    //InputFieldManager inputFieldManager;
    [SerializeField]
    int GenCount=2;


    public void MonsterGeneration()
    {
        for(int i=0;i<GenCount;++i)
        {
            int monstertype = Random.Range(0, statusManager.Statuss.Length);
            int conditiontype = Random.Range(0, conditionManager.conditionBonuss.Length);
            Debug.Log(statusManager.Statuss[monstertype].monstername);
            Debug.Log(conditionManager.conditionBonuss[conditiontype].name);
            monsterManager.monsters.Add(StatusGenerate.GenStatus(statusManager.Statuss[monstertype], conditionManager.conditionBonuss[conditiontype]));
        }
        objSetter.SetObj();
        //inputFieldManager.CreateInputFields();
    }
}

