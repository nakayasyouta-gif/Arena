using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MonsterCheck
{
    MonsterManager monsterManager;
    BetManager betManager;

    public MonsterCheck(MonsterManager monstermanager,BetManager betmanager)
    {
        monsterManager = monstermanager;
        betManager = betmanager;
    }

    public void MonsterDead(int no)
    {
        Debug.Log($"{monsterManager.monsters[no].monstername}‚Í‚½‚¨‚ê‚½");

        // monsterManager.RemoveMonster(no);
        monsterManager.monsters[no].activemonster = false;
        CheckMonsters();
    }

    public void CheckMonsters()
    {
        int activeCount = 0;
        MonsterStatus winner = null;

        foreach (var monster in monsterManager.monsters)
        {
            if (monster.activemonster)
            {
                activeCount++;
                winner = monster;
            }
        }

        if (activeCount > 1)
            return;

        // ŸÒ‚ª‚¢‚È‚¢
        if (winner == null)
            return;

        Debug.Log($"{winner.monstername}‚ÌŸ‚¿");

        GoldManager.gold += betManager.ReturnGold();

        SceneChanger.SceneLoaded();
    }
}