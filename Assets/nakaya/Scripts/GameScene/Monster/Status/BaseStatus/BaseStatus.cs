using UnityEngine;

[CreateAssetMenu(fileName = "Status", menuName = "Monster/Status")]
public class BaseStatus : ScriptableObject
{
    [field: Header("モンスターのデフォルトの名前(種族名)")]
    [field: SerializeField]
    public string monstername { get; private set; }

    [field: Header("属性")]
    [field: SerializeField]
    public Element element { get; private set; }

    [field: Header("最低ステータス(0:最大hp,1:hp,2:atk,3:def,4:crit,5:speed,6:モンスターパワー)")]
    [field: SerializeField]
    public float[] bases { get; private set; } = new float[(int)StatusCategory.count];

    [field: Header("最高ボーナスステータス(0:最大hp,1:hp,2:atk,3:def,4:crit,5:speed,6:モンスターパワー)")]
    [field: SerializeField]
    public float[] bonuss { get; private set; } = new float[(int)StatusCategory.count];
}