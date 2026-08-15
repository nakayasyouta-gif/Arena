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
    Vector2 monstermovepower;

    [SerializeField]
    ObjManager objManager;

    int count = 0;

    public void SetObjPos(GameObject monster)
    {
        monster.transform.position = monsterpos[count];
        ++count;
    }

    public void MoveObj(int no)
    {
        Transform obj = objManager.monsterobjs[no].transform;

        Vector3 originalPos = obj.localPosition;

        obj.localPosition = new Vector3(obj.localPosition.x + monstermovepower.x,obj.localPosition.y + monstermovepower.y,obj.localPosition.z);

        StartCoroutine(ReturnPosition(obj, originalPos));
    }

    private System.Collections.IEnumerator ReturnPosition(Transform obj,Vector3 originalPos)
    {
        yield return new WaitForSeconds(0.5f);

        obj.localPosition = originalPos;
    }
}