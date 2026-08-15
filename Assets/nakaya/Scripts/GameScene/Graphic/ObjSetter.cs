using System.Collections.Generic;
using UnityEngine;

public class ObjSetter : MonoBehaviour
{
    [SerializeField]
    ObjManager objManager;
    [SerializeField]
    SystemManager systemManager;
    MonsterManager monsterManager;

    [Header("グラフィックなどを持たせたオブジェクト")][SerializeField]
    GameObject[] monsterobjs;

    private void Awake()
    {
        monsterManager=systemManager.monsterManager;
    }
    /// <summary>
    /// オブジェクトのデータを取り出す
    /// </summary>
    public void SetObj()
    {
        int count = 0;
        List<string> names = new List<string>();
        foreach (var monster in monsterManager.monsters)
        {
            names.Add(monster.monstername);
            foreach(var monsterobj in monsterobjs)
            {
                if (monsterobj.name != names[count]) continue;
                objManager.CreateMonsterObj(monsterobj);
            }
            ++count;
        }
    }

}
