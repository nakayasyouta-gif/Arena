using UnityEngine;
[CreateAssetMenu(fileName = "Condition", menuName = "Monster/Condition")]
public class ConditionBonus:ScriptableObject
{
    [field: Header("ステータス0:最大hp,1:hp,2:atk,3:def,4:crit,5:speed,6:モンスターパワー")][field: SerializeField]
    public float[] conditions = new float[(int)StatusCategory.count];
}
