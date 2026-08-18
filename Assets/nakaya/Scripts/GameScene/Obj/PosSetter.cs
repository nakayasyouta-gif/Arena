using UnityEngine;

/// <summary>
/// モンスターを動かす
/// </summary>
public class PosSetter : MonoBehaviour
{
    [Header("n番目のモンスターの位置")]
    [SerializeField]
    Vector2[] monsterpos;


    [SerializeField]
    ObjManager objManager;

    int count = 0;

    public void SetObjPos(GameObject monster)
    {
        monster.transform.position = monsterpos[count];
        ++count;
    }
}