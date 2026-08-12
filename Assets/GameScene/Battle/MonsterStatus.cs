using UnityEngine;

/// <summary>
/// 戦闘で使用するステータス
/// </summary>
public class MonsterStatus
{
    /// <summary>
    /// 諸々含めたモンスターのステータス
    /// </summary>
    public float[] statuss { get; private set; } = new float[(int)StatusCategory.count];
    /// <summary>
    /// モンスターの名前
    /// </summary>
    public string monstername { get; set; }

    /// <summary>
    /// モンスターの属性
    /// </summary>
    public Element element { get; private set; }

    /// <summary>
    /// モンスターの調子
    /// </summary>
    public ConditionBonus conditionBonus { get; private set; }
    /// <summary>
    /// 行動までの時間
    /// </summary>

    public float actcd { get { return 5f - (statuss[(int)StatusCategory.speed] * 0.05f); }}

public MonsterStatus(float[] statusvalue, string name, Element element, ConditionBonus condition)
    {
        this.element = element;
        monstername = name;
        conditionBonus = condition;
        for (int i = 0; i < (int)StatusCategory.count; ++i)
        {
            statuss[i] = statusvalue[i];
        }
    }
}
