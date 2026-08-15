using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 生成されたオブジェクトを持つ
/// </summary>
public class ObjManager : MonoBehaviour
{
    public List<GameObject> monsterobjs { get; private set; } = new List<GameObject>();

    [SerializeField]
    PosSetter posSetter;
    public void CreateMonsterObj(GameObject monster)
    {
        GameObject obj = Instantiate(monster);

        monsterobjs.Add(obj);

        posSetter.SetObjPos(obj);
    }
}