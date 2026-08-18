using UnityEngine;

/// <summary>
/// 一部スクリプトをAwakeで初期化する
/// </summary>
public class Initialiser : MonoBehaviour
{
    [SerializeField]
    MonsterGenerate monsterGenerate;
    [SerializeField]
    GamblingManager gamblingManager;
    private void Awake()
    {
        monsterGenerate.MonsterGeneration();
        gamblingManager.initialise();
    }
}
