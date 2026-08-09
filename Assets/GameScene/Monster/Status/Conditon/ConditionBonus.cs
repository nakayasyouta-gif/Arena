using UnityEngine;
[CreateAssetMenu(fileName = "Condition", menuName = "Monster/Condition")]
public class ConditionBonus:ScriptableObject
{
    [field: Header("ステータス(0:hp,1:atk,2:def,3:crit,4:speed)")][field: SerializeField]
    public float[] conditions { get; set; } = new float[(int)StatusCategory.count];
}
