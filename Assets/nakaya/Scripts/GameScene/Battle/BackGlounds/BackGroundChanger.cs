using UnityEngine;
using UnityEngine.UI;

public class BackGroundChanger : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer background;

    [SerializeField]
    Sprite[] backgrounds;

    private void Start()
    {
        int arenaCount = SceneChanger.GetArenaCount();

        switch (arenaCount)
        {
            case 1:
            case 2:
                background.sprite = backgrounds[0];
                break;

            case 3:
            case 4:
                background.sprite = backgrounds[1];
                break;

            case 5:
                background.sprite = backgrounds[2];
                break;
        }
    }
}