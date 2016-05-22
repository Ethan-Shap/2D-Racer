using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BrightnessController : MonoBehaviour {

    private PlayerPrefsManager pPM;

	// Use this for initialization
	void Start () {
        pPM = GameObject.FindObjectOfType<PlayerPrefsManager>();

        pPM.SetBrightness(0);
        ChangeBrightness(pPM.GetBrightness());
    }

    public void ChangeBrightness(int brightness)
    {
        Debug.Log(GetComponent<Image>().color);
        Color c = GetComponent<Image>().color;
        c.a = brightness;
        GetComponent<Image>().color = c;
    }

}
