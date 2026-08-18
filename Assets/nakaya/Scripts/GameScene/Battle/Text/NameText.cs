using TMPro;
using UnityEngine;

/// <summary>
/// モンスターの名前のテキスト
/// </summary>
public class NameText : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI nametext;

    [SerializeField]
    int monsterno;
    [SerializeField]
    MonsterManager monsterManager;

    private void Start()
    {
        if (monsterManager == null)
        {
            monsterManager = GameObject.Find("MonsterManager").GetComponent<MonsterManager>();
        }
        nametext.text = $"{monsterManager.monsters[monsterno].monstername}";
    }

}
