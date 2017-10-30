using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class FloatingUI : MonoBehaviour {

    private RectTransform rectTransform;
    public float xspeed, xAmplitude, yspeed, yAmplitude;

	// Use this for initialization
	void Start () {
        rectTransform = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
        rectTransform.localPosition = new Vector3(xAmplitude * Mathf.Sin(Time.time * xspeed), yAmplitude * Mathf.Sin(Time.time * yspeed), 0);
	}
}
