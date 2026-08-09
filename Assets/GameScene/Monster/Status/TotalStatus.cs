using UnityEngine;

public class TotalStatus
{
    BaseStatus status;
    ConditionBonus conditionBonus;

    public float[] totals { get; set; }
    public Element element { get; private set; }
    public float rate { get; private set; }
    public TotalStatus(BaseStatus bases,ConditionBonus conditions)
    {
        status = bases;
        conditionBonus=conditions;
    }
    private void GenTotalStatus()
    {
        for (int i = 0; i > (int)StatusCategory.count; ++i)
        {
            totals[i] = status.bases[i]*conditionBonus.conditions[i];
            Debug.Log(totals[i]);
        }
    }
}
