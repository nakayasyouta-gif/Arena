using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// 入力受け付け場所を作って持つ
/// </summary>
public class InputFieldManager : MonoBehaviour
{
    [SerializeField]
    TMP_InputField inputfield;

    [SerializeField]
    Transform fieldparent;

    [SerializeField]
    MonsterManager monstermanager;

    [SerializeField]
    NumberInput numberInput;

    [Header("画面座標（左下が0,0）")]
    [SerializeField]
    Vector2[] inputFieldPositions;

    List<TMP_InputField> inputfields = new List<TMP_InputField>();

    private void Start()
    {
        CreateInputFields();
    }

    void CreateInputFields()
    {
        Canvas canvas = fieldparent.GetComponentInParent<Canvas>();

        for (int i = 0; i < monstermanager.monsters.Count; ++i)
        {
            TMP_InputField field =
                Instantiate(inputfield, fieldparent);

            Vector2 screenPosition = inputFieldPositions[i];

            Camera cam = null;

            if (canvas.renderMode != RenderMode.ScreenSpaceOverlay)
            {
                cam = canvas.worldCamera;
            }

            RectTransformUtility.ScreenPointToWorldPointInRectangle(
                canvas.GetComponent<RectTransform>(),
                screenPosition,
                cam,
                out Vector3 worldPosition
            );

            field.transform.position = worldPosition;

            int index = i;

            field.onEndEdit.AddListener((text) =>
            {
                numberInput.CheckNumber(index, text,field);
            });

            inputfields.Add(field);
        }
    }
}