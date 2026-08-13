using System.Collections.Generic;
using UnityEngine;

public class MonsterAct
{
    MonsterManager monsterManager;
    HpCalculator hpCalculator;

    /// <summary>
    /// モンスターごとの行動CT
    /// </summary>
    List<float> actcds = new List<float>();

    /// <summary>
    /// targets[攻撃側モンスター][攻撃対象]
    /// </summary>
    List<List<int>> targets = new List<List<int>>();

    public MonsterAct( MonsterManager monstermanager, HpCalculator hpcalculator)
    {
        monsterManager = monstermanager;
        hpCalculator = hpcalculator;

        SetActcds();
        SetTargets();

        monsterManager.OnMonsterRemoved += OnMonsterRemoved;
    }

    private void OnMonsterRemoved(int no)
    {
        Debug.Log($"MonsterAct: {no}番のモンスターが削除された");

        actcds.RemoveAt(no);

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

            for (int j = 0; j < monsterManager.monsters.Count; ++j)
            {
                if (i != j)
                {
                    targets[i].Add(j);
                }
            }
        }
    }

    public void ResetActcd(int cdno)
    {
        actcds[cdno] = monsterManager.monsters[cdno].actcd;
    }

    public void CountCd()
    {
        for (int i = 0; i < actcds.Count; ++i)
        {
            actcds[i] -= Time.deltaTime;

            if (actcds[i] <= 0f)
            {
                if (targets[i].Count == 0)
                {
                    ResetActcd(i);
                    continue;
                }

                int targetno =
                    targets[i][Random.Range(0, targets[i].Count)];

                hpCalculator.Damage(i, targetno);

                if (i >= monsterManager.monsters.Count)continue;

                ResetActcd(i);
            }
        }
    }
}