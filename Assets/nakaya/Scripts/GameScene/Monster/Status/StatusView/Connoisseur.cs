using UnityEngine;

/// <summary>
/// –Ú—˜‚«ƒŒƒxƒ‹
/// </summary>
public static class Connoisseur
{
    static ConnoisseurLevel conditionconnoisseurlevel;

    static ConnoisseurLevel[] statusconnoisseurlevels =new ConnoisseurLevel[(int)StatusCategory.speed+1];

    public static ConnoisseurLevel GetStatusConnoisseurLevel(StatusCategory category)
    {
        return statusconnoisseurlevels[(int)category];
    }

    public static void SetStatusConnoisseurLevel(StatusCategory category, ConnoisseurLevel level)
    {
        statusconnoisseurlevels[(int)category] = level;
    }

    public static ConnoisseurLevel GetConditionConnoisseurLevel()
    {
        return conditionconnoisseurlevel;
    }

    public static void SetConditionConnoisseurLevel(ConnoisseurLevel level)
    {
        conditionconnoisseurlevel = level;
    }
}