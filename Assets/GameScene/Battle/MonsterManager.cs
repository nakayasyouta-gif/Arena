using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ボーナスとかもろもろいれたステータスの記憶
/// </summary>
public class MonsterManager:MonoBehaviour
{
    /// <summary>
    /// 試合にいるモンスター
    /// </summary>
    public List<MonsterStatus> monsters { get; set; } = new List<MonsterStatus>();
}
