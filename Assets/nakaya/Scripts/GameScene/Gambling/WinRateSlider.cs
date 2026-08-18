using UnityEngine;
using UnityEngine.UI;

public class WinRateSlider : MonoBehaviour
{
    [SerializeField]
    Slider slider;

    [SerializeField]
    GamblingManager gamblingManager;

    private void Start()
    {
        SetWinRate();
    }

    public void SetWinRate()
    {
        float awinrate =gamblingManager.winRateManager.winrates[0];

        slider.minValue = 0f;
        slider.maxValue = 1f;
        slider.value = awinrate;
    }
}