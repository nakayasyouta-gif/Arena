using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarManager : MonoBehaviour
{
    MonsterManager monsterManager;

    ObjManager objManager;

    [SerializeField]
    GameObject hpBarPrefab;

    [SerializeField]
    Transform hpBarParent;

    [SerializeField]
    Camera maincamera;
    public List<Slider> hpBars { get; private set; } = new List<Slider>();

    private void Start()
    {
        monsterManager = GameObject.Find("MonsterManager").GetComponent<MonsterManager>();
        objManager = GameObject.Find("ObjManager").GetComponent<ObjManager>();
        foreach(var monster in monsterManager.monsters)
        {
            CreateHpBar();
        }
       
    }
    /// <summary>
    /// HPバーを追加
    /// </summary>
    public void CreateHpBar()
    {
        GameObject obj =Instantiate(hpBarPrefab, hpBarParent);

        Slider slider = obj.GetComponent<Slider>();

        hpBars.Add(slider);

        int no = hpBars.Count - 1;

        UpdateHp(no);
    }

    /// <summary>
    /// 指定したモンスターのHPバーを更新
    /// </summary>
    public void UpdateHp(int no)
    {
        if (no < 0 || no >= hpBars.Count)return;

        if (no >= monsterManager.monsters.Count) return;

        MonsterStatus monster = monsterManager.monsters[no];

        float maxHp =monster.statuss[(int)StatusCategory.maxhp];

        float hp = monster.statuss[(int)StatusCategory.hp];

        hpBars[no].maxValue = maxHp;
        hpBars[no].value = hp;
    }

    /// <summary>
    /// HPバーを削除
    /// </summary>
    public void RemoveHpBar(int no)
    {
        if (no <0 || no >= hpBars.Count)return;

        Destroy(hpBars[no].gameObject);

        hpBars.RemoveAt(no);
    }

    private void Update()
    {
        for (int i = 0; i < hpBars.Count; i++)
        {
            if (i >= objManager.monsterobjs.Count) continue;

            Vector3 worldPos = objManager.monsterobjs[i].transform.position;

            Vector3 screenPos =maincamera.WorldToScreenPoint(worldPos);

            hpBars[i].transform.position = screenPos + new Vector3(0, 40f, 0);
        }
    }
}