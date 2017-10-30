using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ChangeColorButton : MonoBehaviour {

    public Color color;

    private Color originalColor;
    private Image img;
    private bool b;

	// Use this for initialization
	void Start () {
        img = GetComponent<Image>();
        originalColor = img.color;
	}
	
	public void onClick()
    {
        if(!b)
        {
            img.color = color;
        }
        else
        {
            img.color = originalColor;
        }
        b = !b;
    }
}
