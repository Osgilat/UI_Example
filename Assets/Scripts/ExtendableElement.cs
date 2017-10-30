using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Image))]
public class ExtendableElement : MonoBehaviour {

    public float speedX;
    public float speedY;
    public float surviveTime;
    public float rotationSpeedX;
    public float rotationSpeedY;
    public float rotationSpeedZ;
    public bool reverseRotation;

    private float x, y;
    private RectTransform rectTransform;
    private Vector2 originalSizeDelta;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalSizeDelta = rectTransform.sizeDelta;
        GetComponent<Image>().CrossFadeAlpha(0f, 0f, false);
        GetComponent<Image>().CrossFadeAlpha(1f, surviveTime, false);
        GameObject.Destroy(gameObject, surviveTime*2);
        StartCoroutine("fadeAway");
    }

    private void Update()
    {
        x += speedX * Time.deltaTime;
        y += speedY * Time.deltaTime;
        rectTransform.sizeDelta = new Vector2(x, y) + originalSizeDelta;
        rectTransform.Rotate(Time.deltaTime * rotationSpeedX, Time.deltaTime * rotationSpeedY, Time.deltaTime * rotationSpeedZ);
    }

    IEnumerator fadeAway()
    {
        yield return new WaitForSeconds(surviveTime);
        GetComponent<Image>().CrossFadeAlpha(0f, surviveTime, false);
        if (reverseRotation)
        {
            rotationSpeedX = -rotationSpeedX;
            rotationSpeedY = -rotationSpeedY;
            rotationSpeedZ = -rotationSpeedZ;
        }
    }

}
