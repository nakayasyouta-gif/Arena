using UnityEngine;

public static class GoldManager
{
    public static float gold { get; set; } = 10000f;

    public static bool CheckGold()
    {
        if (gold>=0)return true;
        return false;
     
    }
}
