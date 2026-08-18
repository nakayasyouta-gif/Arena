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
        Debug.Log($"bet = {bet}");
        Debug.Log($"betno = {betno}");
        Debug.Log($"monster” = {winRateManager.monsterManager.monsters.Count}");

        MonsterStatus monster = winRateManager.monsterManager.monsters[betno];

        Debug.Log($"“q‚¯‚½ƒ‚ƒ“ƒXƒ^[ = {monster.monstername}");
        Debug.Log($"activemonster = {monster.activemonster}");
        Debug.Log($"odds = {winRateManager.odds[betno]}");

        if (monster.activemonster)
        {
            float gold = (float)bet * winRateManager.odds[betno];

            Debug.Log($"Šl“¾ƒS[ƒ‹ƒh = {gold}");

            return (int)gold;
        }

        Debug.Log("“q‚¯‚½ƒ‚ƒ“ƒXƒ^[‚Í•‰‚¯‚Ä‚¢‚é");

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
