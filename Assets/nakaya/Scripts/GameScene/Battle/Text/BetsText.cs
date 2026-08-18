using TMPro;
using UnityEngine;

public class BetText : MonoBehaviour
{
    GamblingManager gamblingManager;
    BetManager betManager;

    [SerializeField]
    TextMeshProUGUI bettext;

    private void Start()
    {
        betManager=gamblingManager.betManager;
    }
    private void OnEnable()
    {
        SetBet();
    }
    void SetBet()
    {
        bettext.text = $"{betManager.bet}";
    }
}
