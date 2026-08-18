using TMPro;
using UnityEngine;

public class ViewStatus : MonoBehaviour
{
    [SerializeField]
    int monsterno;

    [SerializeField]
    MonsterManager monstermanager;

    [SerializeField]
    TextMeshProUGUI[] statustexts = new TextMeshProUGUI[(int)StatusCategory.speed];

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

        for (int i = 0; i <= (int)StatusCategory.crit; i++)
        {
            StatusCategory category = (StatusCategory)i;

            // maxhp‚Ícurrenthp‚Æd•¡‚·‚é‚½‚ß•\Ž¦‚µ‚È‚¢
            if (category == StatusCategory.maxhp)
            {
                continue;
            }

            string value = GetStatusValue(status, category);

            statustexts[i - 1].text = $"{category}: {value}";
        }
    }

    private string GetStatusValue(MonsterStatus status, StatusCategory category)
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

            default:return value.ToString();
        }
    }
}