using UnityEngine;

[CreateAssetMenu(fileName = "Status", menuName = "Monster/Status")]
public class BaseStatus : ScriptableObject
{
    [field: Header("モンスターのデフォルトの名前(種族名)")][field: SerializeField]
    public string monstername { get; private set; }

    [field: Header("属性")][field: SerializeField]
    public Element element { get; private set; }

    [field: Header("基礎レート")][field: SerializeField]
    public float baserate { get; private set; }

    [field: Header("最低ステータス(0:hp,1:atk,2:def,3:crit,4:speed)")][field: SerializeField]
    public float[] bases { get; private set; } = new float[(int)StatusCategory.count];

    [field: Header("最高ボーナスステータス(0:hp,1:atk,2:def,3:crit,4:speed)")][field: SerializeField]
    public float[] bonus { get; private set; } = new float[(int)StatusCategory.count];

    //public float GetBases(int no)
    //{
    //    return bases[no];
    //}

}