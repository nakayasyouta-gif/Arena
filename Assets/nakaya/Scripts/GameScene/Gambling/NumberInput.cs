using TMPro;
using UnityEngine;

/// <summary>
/// InputField‚É‚½‚¹‚é
/// </summary>
public class NumberInput : MonoBehaviour
{
    [SerializeField]
    GamblingManager gamblingManager;

    [SerializeField]
    MonsterManager monsterManager;

    public void CheckNumber(int monsterno, string text, TMP_InputField inputfield)
    {
        if (!int.TryParse(text, out int num))
        {
            inputfield.text = "";
            return;
        }

        if (num > GoldManager.gold)
        {
            inputfield.text = "";
            inputfield.Select();
            inputfield.ActivateInputField();

            return;
        }

        Debug.Log($"“ü—Í‚³‚ê‚½”’l = {num}");

        gamblingManager.betManager.bet = num;
        gamblingManager.betManager.no = monsterno;
    }
}