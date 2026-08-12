using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// モンスターに行動させるスクリプト
/// </summary>
public class MonsterAct
{
    MonsterManager monsterManager;

    HpCalculator hpCalculator;
    /// <summary>
    /// モンスターごとの行動ct
    /// </summary>
    List<float> actcds = new List<float>();

    /// <summary>
    /// targets[攻撃側モンスター][n(攻撃側モンスターを除外した番号)]
    /// </summary>
    List<List<int>> targets = new List<List<int>>();

    public MonsterAct(MonsterManager monstermanager,HpCalculator hpcalculator)
    {
        monsterManager = monstermanager;
        hpCalculator = hpcalculator;
        SetActcds();
        for(int i=0;i<monstermanager.monsters.Count;++i)
        {
            targets.Add(new List<int>());
            for (int j=0;j<monstermanager.monsters.Count;++j)
            {
                if(i!=j)
                {
                    targets[i].Add(j);
                }
               
            }
           
        }
    }
    /// <summary>
    /// cdリストに全てのモンスターを登録する
    /// </summary>
    public void SetActcds()
    {
        foreach (var monster in monsterManager.monsters)
        {
           actcds.Add(monster.actcd);
        }
    }
    /// <summary>
    /// 渡された番号のcdをリセットする
    /// </summary>
    public void SetActcd(int cdno)
    {
        actcds[cdno] = monsterManager.monsters[cdno].actcd;
    }
    /// <summary>
    /// UpDateで呼んでcdを進める
    /// </summary>
    public void CountCd()
    {
        for(int i=0; i<actcds.Count;++i)
        {
            actcds[i] -= Time.deltaTime;
            if(actcds[i]<=0f)
            {
                int targetno;
                targetno = targets[i][Random.Range(0,targets[i].Count)];
                
                hpCalculator.Damage(i, targetno);
            }
        }
    }
}
