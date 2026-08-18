using System.Collections.Generic;
using UnityEngine;

public class ObjManager : MonoBehaviour
{
    public List<GameObject> monsterobjs { get; private set; }= new List<GameObject>();

    [SerializeField]
    PosSetter posSetter;

    private void OnDestroy()
    {
        ClearMonsterObj();
    }
    public void CreateMonsterObj(GameObject monster)
    {
        GameObject obj = Instantiate(monster);

        monsterobjs.Add(obj);

        posSetter.SetObjPos(obj);
        DontDestroyOnLoad(obj);
        //hpBarManager.CreateHpBar();
    }
    public void ClearMonsterObj()
    {
        for (int i = 0; i < monsterobjs.Count; ++i)
        {
            Destroy(monsterobjs[i]);
        }
    }
}