using TMPro;
using UnityEngine;

public class NumberInput : MonoBehaviour
{
    [SerializeField]
    GamblingManager gamblingManager;

    [SerializeField]
    TMP_InputField inputField;

    [SerializeField]
    int monsterno;

    public void CheckNumber(string text)
    {
        Debug.Log($"“ü—Í‚³‚ê‚½•¶Žš = {text}");

        if (!int.TryParse(text, out int num))
        {
            return;
        }

        if (num <= 0 || num > GoldManager.gold)
        {
            inputField.text = "";
            inputField.Select();
            inputField.ActivateInputField();
            return;
        }

        gamblingManager.betManager.bet = num;
        gamblingManager.betManager.betno = monsterno;

        GoldManager.gold -= num;
        OnBattle.Battle = true;
        ArenaLoader.LoadArenaScene();
    }
}