using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageTextManager : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;
    [SerializeField] 
    GameObject damagetextprefab;

    private List<Coroutine> hidecoroutines = new List<Coroutine>();

    [SerializeField] 
    Camera maincamera;
    ObjManager objManager;

    private List<TextMeshProUGUI> damagetexts = new List<TextMeshProUGUI>();

    [SerializeField]
    float textshowtime=0.5f;

    private void Start()
    {
        objManager = GameObject.Find("ObjManager").GetComponent<ObjManager>();
        CreateDamageTexts();
    }

    private void CreateDamageTexts()
    {
        foreach (GameObject monster in objManager.monsterobjs)
        {
            GameObject obj = Instantiate(
                damagetextprefab,
                canvas.transform
            );

            TextMeshProUGUI text = obj.GetComponent<TextMeshProUGUI>();

            text.text = "";

            damagetexts.Add(text);
        }
    }

    private void Update()
    {
        for (int i = 0; i < objManager.monsterobjs.Count; i++)
        {
            if (i >= damagetexts.Count)
                break;

            GameObject monster = objManager.monsterobjs[i];

            if (monster == null)
                continue;

            // モンスターのワールド座標
            Vector3 worldPos = monster.transform.position;

            worldPos += Vector3.up * 1f;
            Vector3 screenPos =maincamera.WorldToScreenPoint(worldPos);

            damagetexts[i].transform.position = screenPos;
        }
    }

    public void ShowDamage(int monsterIndex, float damage)
    {
        if (monsterIndex < 0 || monsterIndex >= damagetexts.Count)
            return;

        damagetexts[monsterIndex].text = damage.ToString();

        if (hidecoroutines.Count <= monsterIndex)
        {
            while (hidecoroutines.Count <= monsterIndex)
                hidecoroutines.Add(null);
        }

        if (hidecoroutines[monsterIndex] != null)
        {
            StopCoroutine(hidecoroutines[monsterIndex]);
        }

        hidecoroutines[monsterIndex] =
            StartCoroutine(HideDamage(monsterIndex));
    }

    private IEnumerator HideDamage(int monsterIndex)
    {
        yield return new WaitForSeconds(textshowtime);

        damagetexts[monsterIndex].text = "";
        hidecoroutines[monsterIndex] = null;
    }
}