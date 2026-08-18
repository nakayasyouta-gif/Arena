using UnityEngine;
/// <summary>
/// 勝率とオッズの計算、保持
/// </summary>
public class WinRateManager
{
    MonsterManager monsterManager;

   public float[] odds { get; set; } =new float[2];
    public float[] winrates { get; set; } = new float[2];

    public WinRateManager(MonsterManager monstermanager)
    {
        monsterManager = monstermanager;
        WinRateGeneration();
    }

    public void WinRateGeneration()
    {
        for(int i = 0; i <odds.Length;++i)
        {
            foreach ( var monster in monsterManager.monsters)
            {
                if (monster == monsterManager.monsters[i]) continue;
                odds[i] = 1 / monster.statuss[(int)StatusCategory.rate];
                winrates[i] = monsterManager.monsters[i].statuss[(int)StatusCategory.rate]/(monsterManager.monsters[i].statuss[(int)StatusCategory.rate] + monster.statuss[(int)StatusCategory.rate]);
                Debug.Log($"オッズ{odds[i]}");
                Debug.Log($"勝率{odds[i]}");
            }
            
        }
    }

}
