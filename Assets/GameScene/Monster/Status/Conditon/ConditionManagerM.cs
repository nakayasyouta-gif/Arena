using UnityEngine;

/// <summary>
/// 調子によるボーナスを記憶する
/// </summary>
public class ConditionManager:MonoBehaviour
{
    /// <summary>
    /// ボーナスの種類
    /// </summary>

    [field:Header(" ボーナスの種類")][field:SerializeField]
    public ConditionBonus[] conditionBonuss { get; private set; }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
