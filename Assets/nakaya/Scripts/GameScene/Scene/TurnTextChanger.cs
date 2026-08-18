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
        DontDestroyOnLoad(daytext);
        DontDestroyOnLoad (turntext);
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateText()
    {
        int day = SceneChanger.GetDayCount();
        int arena = SceneChanger.GetArenaCount();

        daytext.text =$"{day}ì˙ñ⁄";
        turntext.text = $"ëÊ{arena}ééçá";

    }
}