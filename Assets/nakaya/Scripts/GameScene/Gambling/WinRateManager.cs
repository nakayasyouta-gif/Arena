
using UnityEngine;

/// <summary>
/// 勝率とオッズの計算、保持
/// </summary>
public class WinRateManager
{
    public MonsterManager monsterManager { get; private set; }

    public float[] odds { get; set; } = new float[2];
    public float[] winrates { get; set; } = new float[2];

    public WinRateManager(MonsterManager monstermanager)
    {
        monsterManager = monstermanager;
        WinRateGeneration();
    }

    public void WinRateGeneration()
    {
        for (int i = 0; i < odds.Length; ++i)
        {
            int other = (i == 0) ? 1 : 0;

            float myRate = monsterManager.monsters[i].statuss[(int)StatusCategory.rate];

            float otherRate = monsterManager.monsters[other].statuss[(int)StatusCategory.rate];

            // 勝率計算
            float totalRate = myRate + otherRate;

            if (totalRate <= 0)
            {
                winrates[i] = 0f;
            }
            else
            {
                winrates[i] = myRate / totalRate;
            }
        }

        // 勝率を全部計算した後にオッズを計算
        for (int i = 0; i < odds.Length; ++i)
        {
            int other = (i == 0) ? 1 : 0;

            if (winrates[other] <= 0f)
            {
                odds[i] = 0f;
            }
            else
            {
                odds[i] = 1f / winrates[other];
            }

            Debug.Log($"モンスター{i} 勝率: {winrates[i]}");
            Debug.Log($"モンスター{i} オッズ: {odds[i]}");
        }
    }
}