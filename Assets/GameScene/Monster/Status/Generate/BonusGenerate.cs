using UnityEngine;

public static class StatusGenerate
{
    //[field: Header("ステータス(0:hp,1:atk,2:def,3:crit,4:speed)")][field: SerializeField]
    // public static float[] bonuslimits { get; private set; } = new float[(int)StatusCategory.count];
    public static float[] bonuslimit { get; private set; } = new float[(int)StatusCategory.count];
    public static void GenStatus(BaseStatus bases)
   {
        for(int i=0;i>bases.bonus.Length;++i)
        {
            bonuslimit[i] = bases.bonus[i];
        }
       
   }
}
