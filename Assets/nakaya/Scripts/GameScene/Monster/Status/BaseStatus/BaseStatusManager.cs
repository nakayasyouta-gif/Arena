using UnityEngine;

/// <summary>
/// モンスターの基礎ステータスを記憶する　一日の最初のアリーナシーン移動時にこれをつけたオブジェクトを生成したい　ショップシーンで削除
/// </summary>
public class BaseStatusManager:MonoBehaviour
{
    /// <summary>
    /// ボーナスの種類
    /// </summary>

    [field:Header(" モンスターの種類")][field:SerializeField]
    public BaseStatus[] Statuss { get; private set; }
}
