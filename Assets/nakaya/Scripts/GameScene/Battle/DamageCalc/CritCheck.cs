using UnityEngine;

/// <summary>
/// Crit判定用
/// </summary>
public static class CritCheck
{
    /// <summary>
    ///0~100から抽選される値がCritの値より小さければtrue
    /// </summary>
    public static bool critbonus(float Crit)
    {
        if(Crit>=(int)Random.Range(0,100))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
