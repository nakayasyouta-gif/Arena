using UnityEngine;

public class BetManager
{
   public int bet { get; set; } = 0;
    public int no { get; set; }
    WinRateManager winRateManager;
   public BetManager(WinRateManager winratemanager)
    {
       winRateManager = winratemanager;
    }

    public int ReturnGold()
    {
        return bet * (int)winRateManager.odds[no];
    }
}
