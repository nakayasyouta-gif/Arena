using UnityEngine;

public class BetManager
{
   public int bet { get; set; } = 0;
    public int betno { get; set; }
    WinRateManager winRateManager;
   public BetManager(WinRateManager winratemanager)
    {
       winRateManager = winratemanager;
    }
    public int ReturnGold()
    {
        if (winRateManager.monsterManager.monsters[betno].activemonster)
        {
            float gold = (float)bet * (100f / winRateManager.winrates[betno]);

            Debug.Log($"Šl“¾ƒS[ƒ‹ƒh = {gold}");

            return (int)gold;
        }
        return 0;
    }
    //public int ReturnGold()
    //{
    //    if (winRateManager.monsterManager.monsters[betno].activemonster)
    //    {
    //        return bet * (int)winRateManager.odds[betno];
    //    }
    //    else
    //    {
    //        return 0;
    //    }
    //}

}
