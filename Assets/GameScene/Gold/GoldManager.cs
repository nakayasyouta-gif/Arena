using UnityEngine;

public static class GoldManager
{
    static float gold;

    static void SetGold(float value)
    {
        gold = value;
    }

    /// <summary>
    /// “n‚³‚ê‚½”’l‚ğƒS[ƒ‹ƒh‚É‰ÁZ
    /// </summary>
    static void AddGold(float value)
    {
        gold += value;
    }

    static float GetGold()
    {
        return gold;
    }
}
