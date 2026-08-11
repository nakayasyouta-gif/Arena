using UnityEngine;

[CreateAssetMenu(fileName = "Status", menuName = "Monster/Status")]
public class BaseStatus : ScriptableObject
{
    [field: Header("モンスターのデフォルトの名前(種族名)")][field: SerializeField]
    public string monstername { get; private set; }

    [field: Header("属性")][field: SerializeField]
    public Element element { get; private set; }

    [field: Header("最低ステータス(0:hp,1:atk,2:def,3:crit,4:speed,5:モンスターパワー)")][field: SerializeField]
    public float[] bases { get; private set; } = new float[(int)StatusCategory.count];

    [field: Header("最高ボーナスステータス(0:hp,1:atk,2:def,3:crit,4:speed,5:モンスターパワー)")][field: SerializeField]
    public float[] bonuss { get; private set; } = new float[(int)StatusCategory.count];
}