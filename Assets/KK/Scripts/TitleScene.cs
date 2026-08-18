using UnityEngine;
using AudioName;

public class TitleScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.Instance.PlayBGM(BGMName.BET_BGM_NAME);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
