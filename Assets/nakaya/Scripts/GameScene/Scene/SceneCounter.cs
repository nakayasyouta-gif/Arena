using UnityEngine.SceneManagement;

public static class SceneChanger
{
    private static int daycount = 1;
    private static int arenacount = 1;

    public static int GetDayCount()
    {
        return daycount;
    }

    public static int GetArenaCount()
    {
        return arenacount;
    }

    public static void SceneLoaded()
    {
        arenacount++;
        if(!GoldManager.CheckGold())
        {
            //ゲームオーバー
        }
        if (arenacount > 5)
        {
            ++daycount;
            arenacount = 1;
            SceneManager.LoadScene("ShopScene");
        }
        else
        {
            SceneManager.LoadScene("BetScene");
        }
    }
}