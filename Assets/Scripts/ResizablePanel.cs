using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ResizablePanel : MonoBehaviour {

    Vector2 initialMousePos;
    Vector2 initialDeltaSize;
    RectTransform rectTransform;

    private void Start()
    {
        rectTransform = (RectTransform) this.transform;
    }

    public void OnDragBegins()
    {
        initialMousePos = Input.mousePosition;
        initialDeltaSize = rectTransform.sizeDelta;
    }

    public void OnDrag()
    {
        Vector2 temp = (Vector2)initialMousePos - (Vector2)Input.mousePosition;
        temp = new Vector2(-temp.x, temp.y);
        temp += initialDeltaSize;
        rectTransform.sizeDelta = temp;
    }
}
