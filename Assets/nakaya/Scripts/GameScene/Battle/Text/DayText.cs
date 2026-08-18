using TMPro;
using UnityEngine;

public class DayText: MonoBehaviour
{
    [SerializeField]
     TextMeshProUGUI daytext;
    private void OnEnable()
    {
        SetDay();
    }

    void SetDay()
    {
        daytext.text = $"day{SceneChanger.GetDayCount()}";
    }
}
