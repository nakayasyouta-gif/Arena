using System.Collections.Generic;
using UnityEngine;

public class ObjManager : MonoBehaviour
{
    public List<GameObject> monsterobjs { get; private set; }
        = new List<GameObject>();

    [SerializeField]
    PosSetter posSetter;

    [SerializeField]
    HpBarManager hpBarManager;

    public void CreateMonsterObj(GameObject monster)
    {
        GameObject obj = Instantiate(monster);

        monsterobjs.Add(obj);

        posSetter.SetObjPos(obj);

        hpBarManager.CreateHpBar();
    }
}