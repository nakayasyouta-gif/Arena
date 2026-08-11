using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ボーナスとかもろもろいれたステータスの記憶 
/// </summary>
public class MonsterManager:MonoBehaviour
{
    public List<MonsterStatus> monsters { get; set; } = new List<MonsterStatus>();
}
