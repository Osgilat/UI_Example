using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

[RequireComponent(typeof(Slider))]
public class UpperAndLowerBoundsForSlidersScript : MonoBehaviour {

    private Slider slider;

    [Range(0,100)]
    public int lowerBound;
    [Range(0, 100)]
    public int upperBound;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        checkBounds();
    }

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void checkBounds()
    {
        if(slider.value >= upperBound / 100f)
        {
            slider.value = upperBound / 100f;
        }
        else
        {
            if(slider.value <= lowerBound / 100f)
            {
                slider.value = lowerBound / 100f;
            }
        }
    }
}
