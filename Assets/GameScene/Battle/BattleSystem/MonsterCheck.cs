using UnityEngine;

public class MonsterCheck
{
    MonsterManager monsterManager;

    public MonsterCheck(MonsterManager monstermanager)
    {
        monsterManager = monstermanager;
    }

    public void MonsterDead(int no)
    {
        Debug.Log($"{monsterManager.monsters[no].monstername}‚Í‚½‚¨‚ê‚½");

        monsterManager.RemoveMonster(no);

        CheckMonsters();
    }

    public void CheckMonsters()
    {
        if (monsterManager.monsters.Count != 1)
            return;

        Debug.Log($"{monsterManager.monsters[0].monstername}‚ÌŸ‚¿");
    }
}