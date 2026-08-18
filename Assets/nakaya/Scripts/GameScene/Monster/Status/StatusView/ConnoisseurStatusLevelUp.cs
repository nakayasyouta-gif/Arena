using TMPro;
using UnityEngine;

public class ConnoisseurStatusLevelUp : MonoBehaviour
{
    [SerializeField]
    StatusCategory category;

    [SerializeField]
    int lowertomiddlecost = 2500;

    [SerializeField]
    int middletohighcost = 300000;

    [SerializeField]
    TextMeshProUGUI costtext;

    private void Start()
    {
        ViewCost();
    }

    public void LevelUp()
    {
        ConnoisseurLevel currentlevel = Connoisseur.GetStatusConnoisseurLevel(category);

        int cost = 0;

        switch (currentlevel)
        {
            case ConnoisseurLevel.lower:
                cost = lowertomiddlecost;
                break;

            case ConnoisseurLevel.middle:
                cost = middletohighcost;
                break;

            case ConnoisseurLevel.high:
                return;
        }

        if (GoldManager.gold < cost)
        {
            return;
        }

        GoldManager.gold -= cost;

        ++currentlevel;

        Connoisseur.SetStatusConnoisseurLevel(category,currentlevel);

        ViewCost();
    }

    public void ViewCost()
    {
        ConnoisseurLevel currentlevel =Connoisseur.GetStatusConnoisseurLevel(category);

        switch (currentlevel)
        {
            case ConnoisseurLevel.lower:
                costtext.text = lowertomiddlecost.ToString();
                break;

            case ConnoisseurLevel.middle:
                costtext.text = middletohighcost.ToString();
                break;

            case ConnoisseurLevel.high:
                costtext.text = "MAX";
                break;
        }
    }
}