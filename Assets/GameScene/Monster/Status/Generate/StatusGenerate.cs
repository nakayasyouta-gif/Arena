using UnityEngine;

public static class StatusGenerate
{
    public static float[] totalstatuss { get; private set; } = new float[(int)StatusCategory.count];
    public static MonsterStatus GenStatus(BaseStatus bases,ConditionBonus condition)
   {
        for(int i=0;i>bases.bonuss.Length;++i)
        {
            totalstatuss[i] = bases.bases[i] + Random.Range(0, bases.bonuss[i]);
            Debug.Log(totalstatuss[i]);
            
        }
        return new MonsterStatus(totalstatuss, bases.name, bases.element, condition);
   }
}
