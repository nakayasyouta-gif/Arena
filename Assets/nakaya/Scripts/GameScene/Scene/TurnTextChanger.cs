using TMPro;
using UnityEngine;

public class TurnTextChanger : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI daytext;
    [SerializeField]
    TextMeshProUGUI turntext;

    private void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        int day = SceneChanger.GetDayCount();
        int arena = SceneChanger.GetArenaCount();

        daytext.text =$"{day}";
        turntext.text = $"{arena}";

    }
}