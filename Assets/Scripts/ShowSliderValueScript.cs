using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class ShowSliderValueScript : MonoBehaviour {

    private Text uiText;

    void Start()
    {
        uiText = gameObject.GetComponent<Text>();
    }

    public void updateValue(float value)
    {
        uiText.text = Mathf.RoundToInt(value * 100) + " %";
    }

	
}
