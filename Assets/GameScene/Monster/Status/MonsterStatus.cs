using UnityEngine;

/// <summary>
/// 戦闘で使用するステータス
/// </summary>
public class MonsterStatus
{
    public float[] status { get; private set; } = new float[(int)StatusCategory.count];
    public string monstername { get; set; }

    public Element element { get; private set; }

    public ConditionBonus conditionBonus { get; private set; }

    public MonsterStatus(float[] statusvalue, string name, Element element, ConditionBonus condition)
    {
        this.element = element;
        monstername = name;
        conditionBonus = condition;
        for (int i = 0; i < (int)StatusCategory.count; ++i)
        {
            status[i] = statusvalue[i];
        }
    }
}
