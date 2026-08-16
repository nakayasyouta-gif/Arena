using System.Threading;
using UnityEngine;

public class HpCalculator
{
    MonsterManager monsterManager;
    MonsterCheck monsterCheck;
    DamageTextManager damageTextManager;
    HpBarManager hpBarManager;
    public HpCalculator(MonsterManager monstermanager,MonsterCheck monstercheck, DamageTextManager damagetextmanager,HpBarManager hpbarmanager)
    {
        monsterManager = monstermanager;
        monsterCheck = monstercheck;
        damageTextManager = damagetextmanager;
        hpBarManager = hpbarmanager;
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
        Debug.Log($"{monsterManager.monsters[attackno].monstername}‚ÌUŒ‚!");

        float damage= Mathf.Min((monsterManager.monsters[attackno].statuss[(int)StatusCategory.atk] - (monsterManager.monsters[defenceno].statuss[(int)StatusCategory.def] / 3))
        * Random.Range(0.9f, 1.1f) * elementbonus * critbonus, monsterManager.monsters[defenceno].statuss[(int)StatusCategory.hp]);
        damage=Mathf.Floor(damage);
        damage = Mathf.Max(damage,0);
        monsterManager.monsters[defenceno].statuss[(int)StatusCategory.hp] -= damage;
        damageTextManager.ShowDamage(defenceno,damage);
        hpBarManager.UpdateHp(defenceno);
        if (monsterManager.monsters[defenceno].statuss[(int)StatusCategory.hp] > 0) return;
        monsterCheck.MonsterDead(defenceno);
    }

}
