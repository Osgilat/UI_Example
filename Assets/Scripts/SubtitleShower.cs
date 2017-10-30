using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleShower : MonoBehaviour {

    private static Text uiText;

    const float defaultDuration = 5f;

    public static IEnumerator Show(string subtitle, float duration = defaultDuration, AudioClip clip = null)
    {
        uiText.text = subtitle;

        if(clip)
        {
            AudioSource.PlayClipAtPoint(clip, Input.mousePosition);
            yield return new WaitForSeconds(clip.length);
        }
        else
        {
            yield return new WaitForSeconds(duration);
        }

        uiText.text = "";
    }
	// Use this for initialization
	void Start ()
    {
        uiText = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
