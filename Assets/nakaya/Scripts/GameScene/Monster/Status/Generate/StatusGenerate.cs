using UnityEngine;

public static class StatusGenerate
{
   
    public static MonsterStatus GenStatus(BaseStatus bases,ConditionBonus condition)
   {
        float[] totalstatuss = new float[(int)StatusCategory.count];

        for(int i=0;i<bases.bonuss.Length;++i)
        {
            totalstatuss[i] = bases.bases[i] + Random.Range(0, (int)bases.bonuss[i]+1);
            Debug.Log(totalstatuss[i]);
        }
        totalstatuss[(int)StatusCategory.hp] = totalstatuss[(int)StatusCategory.maxhp];
        return new MonsterStatus(totalstatuss, bases.monstername, bases.element, condition);
   }
}
