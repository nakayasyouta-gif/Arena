using TMPro;
using UnityEngine;

public class ViewStatus : MonoBehaviour
{
    [SerializeField]
    int monsterno;

    [SerializeField]
    MonsterManager monstermanager;

    [SerializeField]
    TextMeshProUGUI[] statustexts =
        new TextMeshProUGUI[(int)StatusCategory.speed];

    // 条件名を表示するテキスト
    [SerializeField]
    TextMeshProUGUI conditiontext;

    [SerializeField]
    float minratio = 0.5f;

    [SerializeField]
    float maxratio = 1.5f;

    private void Start()
    {
        StatusView();
    }

    public void StatusView()
    {
        MonsterStatus status = monstermanager.monsters[monsterno];

        conditiontext.text = status.conditionBonus.name;

        for (int i = 0; i <= (int)StatusCategory.speed; i++)
        {
            StatusCategory category = (StatusCategory)i;

            if (category == StatusCategory.maxhp)
            {
                continue;
            }

            string value = GetStatusValue(status, category);

            statustexts[i - 1].text = $"{category}: {value}";
        }
    }

    private string GetStatusValue(
        MonsterStatus status,
        StatusCategory category)
    {
        float value = status.statuss[(int)category];

        switch (Connoisseur.GetStatusConnoisseurLevel(category))
        {
            case ConnoisseurLevel.lower:
                return "?";

            case ConnoisseurLevel.middle:
                float min = value * minratio;
                float max = value * maxratio;

                float randomvalue = Random.Range(min, max);

                if (randomvalue == 0)
                {
                    randomvalue = min;
                }

                return randomvalue.ToString("F1");

            case ConnoisseurLevel.high:
                return value.ToString();

            default:
                return value.ToString();
        }
    }
}