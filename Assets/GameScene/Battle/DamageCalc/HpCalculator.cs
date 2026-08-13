using UnityEngine;

public class HpCalculator
{
    MonsterManager monsterManager;
    MonsterCheck monsterCheck;
    public HpCalculator(MonsterManager monstermanager,MonsterCheck monstercheck)
    {
        monsterManager = monstermanager;
        monsterCheck = monstercheck;
    }
    public void Damage(int attackno,int defenceno)
    {
        float elementbonus;
        float critbonus;

        if (ElementCalculator.elementbonus(monsterManager.monsters[attackno].element, monsterManager.monsters[defenceno].element))
        {
            elementbonus = 1.2f;
        }
        else
        {
            elementbonus = 1f;
        }

        if (CritCheck.critbonus(monsterManager.monsters[attackno].statuss[(int)StatusCategory.crit]))
        {
            critbonus = 2f;
        }
        else
        {
            critbonus = 1f;
        }
        Debug.Log($"{monsterManager.monsters[attackno].monstername}の攻撃!");

        float damage= Mathf.Min((monsterManager.monsters[attackno].statuss[(int)StatusCategory.atk] - (monsterManager.monsters[defenceno].statuss[(int)StatusCategory.def] / 2))
        * Random.Range(0.9f, 1.1f) * elementbonus * critbonus, monsterManager.monsters[defenceno].statuss[(int)StatusCategory.hp]);
        damage=Mathf.Floor(damage);
        monsterManager.monsters[defenceno].statuss[(int)StatusCategory.hp] -= Mathf.Max(damage,1);

        Debug.Log($"{monsterManager.monsters[defenceno].monstername}に{Mathf.Max(damage, 1)}ダメージ！");
        if (monsterManager.monsters[defenceno].statuss[(int)StatusCategory.hp] > 0) return;
        monsterCheck.MonsterDead(defenceno);
    }

}
