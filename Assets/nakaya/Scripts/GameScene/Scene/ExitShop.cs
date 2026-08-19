using UnityEngine;
using AudioName;

public class ExitShop : MonoBehaviour
{
   public void Exit()
    {
        AudioManager.Instance.StopBGM(BGMName.SHOP_BGM_NAME);
        SceneChanger.SceneLoaded();
    }
}
