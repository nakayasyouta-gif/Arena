using UnityEngine;
using AudioName;

public class Shop : MonoBehaviour
{
    private void Start()
    {
        AudioManager.Instance.PlayBGM(BGMName.SHOP_BGM_NAME);
    }
}
