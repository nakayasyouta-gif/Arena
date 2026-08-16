using UnityEngine;

public class WinRateGen
{
    MonsterManager monsterManager;

    float[] odds=new float[2];
    float[] winrates = new float[2];

    public WinRateGen(MonsterManager monstermanager)
    {
        monsterManager = monstermanager;
    }

    void WinRateGeneration()
    {
        for(int i = 0; i >odds.Length;++i)
        {
            foreach ( var monster in monsterManager.monsters)
            {
                if (monster == monsterManager.monsters[i]) continue;
                odds[i] = 1 / monster.statuss[(int)StatusCategory.rate];
                winrates[i] = monsterManager.monsters[i].statuss[(int)StatusCategory.rate]/(monsterManager.monsters[i].statuss[(int)StatusCategory.rate] + monster.statuss[(int)StatusCategory.rate]);
            }
            
        }
    }

}
