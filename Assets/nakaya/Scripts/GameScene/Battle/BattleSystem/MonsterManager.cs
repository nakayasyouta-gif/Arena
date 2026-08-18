using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ボーナスとかもろもろいれたステータスの記憶
/// </summary>
public class MonsterManager : MonoBehaviour
{
    /// <summary>
    /// 試合にいるモンスター
    /// </summary>
    public List<MonsterStatus> monsters { get; set; } = new List<MonsterStatus>();

    /// <summary>
    /// モンスターが削除されたときに発生するイベント
    /// 引数 = 削除されたモンスターの番号
    /// </summary>
    public event Action<int> OnMonsterRemoved;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void RemoveMonster(int no)
    {
        monsters.RemoveAt(no);

        OnMonsterRemoved?.Invoke(no);
    }
}