using UnityEngine;

public class MonsterCheck
{
    MonsterManager monsterManager;
    BetManager betManager;
    ResultObject resultObject;

    public MonsterCheck(MonsterManager monstermanager, BetManager betmanager, ResultObject resultobject)
    {
        monsterManager = monstermanager;
        betManager = betmanager;
        resultObject = resultobject;
    }

    public void MonsterDead(int no)
    {
        Debug.Log($"{monsterManager.monsters[no].monstername}はたおれた");

        monsterManager.monsters[no].activemonster = false;

        CheckMonsters();
    }

    /// <summary>
    /// バトルが終了したら勝者の番号を返す 終了していなければ -1
    /// </summary>
    public int CheckMonsters()
    {
        int activeCount = 0;
        int winnerNo = -1;

        for (int i = 0; i < monsterManager.monsters.Count; i++)
        {
            if (monsterManager.monsters[i].activemonster)
            {
                activeCount++;
                winnerNo = i;
            }
        }
        if (activeCount > 1)
        {
            return -1;
        }
        Debug.Log($"勝者 = {monsterManager.monsters[winnerNo].monstername}");
        resultObject.BattleEnd(winnerNo);

        return winnerNo;
    }
}