using UnityEngine.SceneManagement;

public static class SceneChanger
{
    private static int arenaCount = 0;

    public static void SceneLoaded()
    {
        arenaCount++;

        if (arenaCount >= 5)
        {
            arenaCount = 0; 
            SceneManager.LoadScene("ShopScene");
        }
        else
        {
            ArenaLoader.LoadArenaScene();
        }
    }
}