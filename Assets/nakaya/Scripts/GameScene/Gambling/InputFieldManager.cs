//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;

//public class InputFieldManager : MonoBehaviour
//{
//    [SerializeField]
//    TMP_InputField inputfield;

//    [SerializeField]
//    Transform fieldparent;

//    [SerializeField]
//    MonsterManager monstermanager;

//    [SerializeField]
//    NumberInput numberInput;

//    [Header("âÊñ ç¿ïWÅiç∂â∫Ç™0,0Åj")]
//    [SerializeField]
//    Vector2[] inputFieldPositions;

//    List<TMP_InputField> inputfields = new List<TMP_InputField>();

//    public void CreateInputFields()
//    {
//        Canvas canvas = fieldparent.GetComponentInParent<Canvas>();

//        for (int i = 0; i < monstermanager.monsters.Count; ++i)
//        {
//            TMP_InputField field =Instantiate(inputfield, fieldparent);

//            Vector2 screenPosition = inputFieldPositions[i];

//            Camera cam = null;

//            if (canvas.renderMode != RenderMode.ScreenSpaceOverlay)
//            {
//                cam = canvas.worldCamera;
//            }

//            RectTransformUtility.ScreenPointToWorldPointInRectangle(
//                canvas.GetComponent<RectTransform>(),
//                screenPosition,
//                cam,
//                out Vector3 worldPosition
//            );

//            field.transform.position = worldPosition;

//            int index = i;

//            field.onEndEdit.AddListener((text) =>
//            {
//                numberInput.CheckNumber(index, text, field);
//            });

//            inputfields.Add(field);
//        }
//    }
//}