using System.Collections.Generic;
using UnityEngine;

public class MonsterAct
{
    MonsterManager monsterManager;
    HpCalculator hpCalculator;

    public List<float> actcds { get; private set; } = new List<float>();

    List<List<int>> targets = new List<List<int>>();

    public MonsterAct(MonsterManager monstermanager, HpCalculator hpcalculator)
    {
        monsterManager = monstermanager;
        hpCalculator = hpcalculator;

        SetActcds();
        SetTargets();
    }

    public void SetActcds()
    {
        actcds.Clear();

        foreach (var monster in monsterManager.monsters)
        {
            actcds.Add(monster.actcd);
        }
    }

    public void SetTargets()
    {
        targets.Clear();

        for (int i = 0; i < monsterManager.monsters.Count; ++i)
        {
            targets.Add(new List<int>());

            // UŒ‚Ò©g‚ª€–S‚µ‚Ä‚¢‚½‚ç‘ÎÛİ’è‚µ‚È‚­‚Ä‚àOK
            if (!monsterManager.monsters[i].activemonster)
                continue;

            for (int j = 0; j < monsterManager.monsters.Count; ++j)
            {
                if (i == j)
                    continue;

                // €–S‚µ‚Ä‚¢‚éƒ‚ƒ“ƒXƒ^[‚ÍUŒ‚‘ÎÛ‚É‚µ‚È‚¢
                if (!monsterManager.monsters[j].activemonster)
                    continue;

                targets[i].Add(j);
            }
        }
    }

    public void ResetActcd(int cdno)
    {
        if (cdno < 0 || cdno >= actcds.Count)
            return;

        if (cdno >= monsterManager.monsters.Count)
            return;

        actcds[cdno] = monsterManager.monsters[cdno].actcd;
    }

    public void CountCd()
    {
        List<int> canAct = new List<int>();

        for (int i = 0; i < actcds.Count; ++i)
        {
            if (i >= monsterManager.monsters.Count)continue;

            if (!monsterManager.monsters[i].activemonster)continue;

            if (targets.Count <= i)continue;

            if (targets[i].Count == 0)continue;

            actcds[i] -= Time.deltaTime;

            if (actcds[i] <= 0f)
            {
                canAct.Add(i);
            }
        }

        if (canAct.Count == 0)return;

        int randomIndex = Random.Range(0, canAct.Count);
        int attackNo = canAct[randomIndex];

        if (!monsterManager.monsters[attackNo].activemonster)return;

        // ƒ^[ƒQƒbƒg‚ğÄŠm”F
        SetTargets();

        if (targets[attackNo].Count == 0) return;

        int targetNo =targets[attackNo][Random.Range(0, targets[attackNo].Count)];

        // UŒ‚‘ÎÛ‚ª€–S‚µ‚Ä‚¢‚È‚¢‚©Šm”F
        if (!monsterManager.monsters[targetNo].activemonster)return;

        hpCalculator.Damage(attackNo, targetNo);
    }
}