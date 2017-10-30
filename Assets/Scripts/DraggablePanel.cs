using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggablePanel : MonoBehaviour {

    public void OnDrag()
    {
        transform.position = Input.mousePosition;
    }
}
