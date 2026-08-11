using UnityEngine;

/// <summary>
/// モンスターの基礎ステータスを記憶する
/// </summary>
public class BaseStatusManager:MonoBehaviour
{
    /// <summary>
    /// ボーナスの種類
    /// </summary>

    [field:Header(" モンスターの種類")][field:SerializeField]
    public BaseStatus[] Statuss { get; private set; }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
