using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class DistanceDisplayer : MonoBehaviour {

    public Transform player;
    public Transform target;

    public float farthestDistance;

    public Color firstColor;
    public Color secondColor;

    private Image img;
    private Text txt;

	// Use this for initialization
	void Start ()
    {
        img = GetComponent<Image>();
        txt = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float distance = Vector3.Distance(player.position, target.position);
        txt.text = distance.ToString("F2");

        img.color = Color.Lerp(firstColor, secondColor, 1 - (distance / farthestDistance));
	}
}
