using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider, difficultySlider, brightnessSlider;

    private LevelManager lM;
    private PlayerPrefsManager pPM;
    private MusicManager mM;
    private BrightnessController bC;

    private void Awake()
    {
        lM = GameObject.FindObjectOfType<LevelManager>();
        pPM = GameObject.FindObjectOfType<PlayerPrefsManager>();
        mM = GameObject.FindObjectOfType<MusicManager>();
        bC = GameObject.FindObjectOfType<BrightnessController>();

        volumeSlider.value = pPM.GetMasterVolume();
        difficultySlider.value = pPM.GetDifficulty();
        brightnessSlider.value = pPM.GetBrightness();

    }

    void Update()
    {
        mM.ChangeVolume(volumeSlider.value);
        bC.ChangeBrightness(Mathf.RoundToInt(brightnessSlider.value));
    }

    public void Defaults()
    {
        volumeSlider.value = volumeSlider.minValue;
        difficultySlider.value = difficultySlider.minValue;
        brightnessSlider.value = brightnessSlider.maxValue / 2;
    }

    public void SaveAndStart()
    {
        pPM.SetMasterVolume(volumeSlider.value);
        pPM.SetDifficulty(Mathf.RoundToInt(difficultySlider.value));
        pPM.SetBrightness(Mathf.RoundToInt(brightnessSlider.value));
        lM.LoadScene("LevelSelector");
    }

    public void SaveAndExit()
    {
        pPM.SetMasterVolume(volumeSlider.value);
        pPM.SetDifficulty(Mathf.RoundToInt(difficultySlider.value));
        pPM.SetBrightness(Mathf.RoundToInt(brightnessSlider.value));
        lM.LoadScene("Start");
    }

}
