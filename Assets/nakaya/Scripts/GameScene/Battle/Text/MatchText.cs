using TMPro;
using UnityEngine;

public class MatchText: MonoBehaviour
{
    [SerializeField]
     TextMeshProUGUI matchtext;
    private void OnEnable()
    {
        SetMatch();
    }

    void SetMatch()
    {
        matchtext.text = $"day{SceneChanger.GetArenaCount()}";
    }
}
