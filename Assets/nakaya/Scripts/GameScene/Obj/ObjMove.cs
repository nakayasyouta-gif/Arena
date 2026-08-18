using UnityEngine;

public class ObjMove : MonoBehaviour
{
    ObjManager objManager {get;set; }

    [SerializeField]
    Vector2 monstermovepower;

    private void Start()
    {
        objManager = GameObject.Find("ObjManager").GetComponent<ObjManager>();
    }
    public void MoveObj(int no)
    {
        Transform obj = objManager.monsterobjs[no].transform;

        Vector3 originalPos = obj.localPosition;

        obj.localPosition = new Vector3(obj.localPosition.x + monstermovepower.x, obj.localPosition.y + monstermovepower.y, obj.localPosition.z);

        StartCoroutine(ReturnPosition(obj, originalPos));
    }

    private System.Collections.IEnumerator ReturnPosition(Transform obj, Vector3 originalPos)
    {
        yield return new WaitForSeconds(0.5f);

        obj.localPosition = originalPos;
    }
}
