using TMPro;
using UnityEngine;

public class ConnoisseurConditionLevelUp : MonoBehaviour
{
    [SerializeField]
    int conditioncost = 150000;

    [SerializeField]
    TextMeshProUGUI costtext;

    private void Start()
    {
        ViewCost();
    }

    public void LevelUp()
    {
        ConnoisseurLevel currentlevel =
            Connoisseur.GetConditionConnoisseurLevel();

        if (currentlevel == ConnoisseurLevel.high)
        {
            return;
        }

        if (GoldManager.gold < conditioncost)
        {
            return;
        }

        GoldManager.gold -= conditioncost;

        Connoisseur.SetConditionConnoisseurLevel(
            ConnoisseurLevel.high);

        ViewCost();
    }

    public void ViewCost()
    {
        ConnoisseurLevel currentlevel =
            Connoisseur.GetConditionConnoisseurLevel();

        if (currentlevel == ConnoisseurLevel.high)
        {
            costtext.text = "MAX";
        }
        else
        {
            costtext.text = conditioncost.ToString();
        }
    }
}