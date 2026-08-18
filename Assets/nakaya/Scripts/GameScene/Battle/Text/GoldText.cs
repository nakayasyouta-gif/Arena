using TMPro;
using UnityEngine;

public class GoldText : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI goldtext;
   
    void GoldTextSet()
    {
        goldtext.text = $"Gold:{GoldManager.gold}";
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        GoldTextSet();
    }
    private void Update()
    {
        int.TryParse(goldtext.text, out int gold);
        if (gold == GoldManager.gold) return;
        goldtext.text = $"èäéùã‡ÅF{GoldManager.gold}â~";
    }
}   