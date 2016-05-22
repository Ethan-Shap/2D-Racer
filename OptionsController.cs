using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

    public Slider brightnessSlider;
    private BrightnessController bC;

    private void Awake()
    {
        bC = GameObject.FindObjectOfType<BrightnessController>();

        brightnessSlider.value = pPM.GetBrightness();

    }

    void Update()
    {
        bC.ChangeBrightness(Mathf.RoundToInt(brightnessSlider.value));
    }

}
