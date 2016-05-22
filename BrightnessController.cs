using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BrightnessController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ChangeBrightness(0);
    }

    public void ChangeBrightness(int brightness)
    {
        Debug.Log(GetComponent<Image>().color);
        Color c = GetComponent<Image>().color;
        c.a = brightness;
        GetComponent<Image>().color = c;
    }

}
