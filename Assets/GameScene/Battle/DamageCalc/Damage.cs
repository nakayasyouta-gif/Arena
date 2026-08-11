using UnityEngine;

public class HpCalculator
{
    MonsterManager monsterManager;
    public void Damage(int attackno,int defenceno)
    {
        float bonus=1f;
        float critbonus=2f;
        //if(‘Š«ˆ—)
        monsterManager.monsters[defenceno].status[0] -=
            (monsterManager.monsters[attackno].status[1] - (monsterManager.monsters[defenceno].status[2] / 2))
            * Random.Range(0.9f, 1.1f) * bonus * critbonus;
    }

}
