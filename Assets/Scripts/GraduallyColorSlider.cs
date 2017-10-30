using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraduallyColorSlider : MonoBehaviour {

    public Image img;
    public Color firstColor;
    public Color secondColor;

	public void Change(float value)
    {
        img.color = Color.Lerp(firstColor, secondColor, value);
    }
}
