using TMPro;
using UnityEngine;

/// <summary>
/// モンスターのオッズのテキスト
/// </summary>
public class OddsText : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI oddstext;

    [SerializeField]
    int monsterno;
    [SerializeField]
    GamblingManager gamblingManager;
    WinRateManager winRateManager;

    private void Start()
    {
        winRateManager = gamblingManager.winRateManager;
        oddstext.text=$"{winRateManager.odds[monsterno]}倍";
    }

}
