using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltEffect : MonoBehaviour {

    public Vector2 range = new Vector2(10f, 6f);
    public float speed = 5f;

    private Vector2 tiltRotation = Vector2.zero;
    private Vector3 originalRotation;
	// Use this for initialization
	void Start () {
        originalRotation = new Vector3(transform.localRotation.z, transform.localRotation.x, transform.localRotation.y);
	}
	
	// Update is called once per frame
	void Update () {
        float halfWidth = Screen.width / 2f;
        float halfHeight = Screen.height / 2f;

        float x = Mathf.Clamp((Input.mousePosition.x - halfWidth) / halfWidth, -1f, 1f);
        float y = Mathf.Clamp((Input.mousePosition.y - halfHeight) / halfHeight, -1f, 1f);

        tiltRotation = Vector2.Lerp(tiltRotation, new Vector2(x, y), Time.deltaTime * speed);

        transform.localRotation = Quaternion.Euler(-tiltRotation.y * range.y, tiltRotation.x * range.x, 0f);
	}
}
