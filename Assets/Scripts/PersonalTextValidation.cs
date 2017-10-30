using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class PersonalTextValidation : MonoBehaviour {

    private InputField inputField;
    private string oldText;

	// Use this for initialization
	void Start () {
        inputField = GetComponent<InputField>();
        oldText = inputField.text;
	}

    public void Check(string newText)
    {
        if(newText == "")
        {
            oldText = newText;
            return;
        }

        if(newText[0] == '1' ||
            newText[0] == '2' ||
            newText[0] == '3' ||
            newText[0] == '4' ||
            newText[0] == '5' ||
            newText[0] == '6' ||
            newText[0] == '7' ||
            newText[0] == '8' ||
            newText[0] == '9' ||
            newText[0] == '0')
        {
            inputField.text = oldText;
        }
        else
        {
            oldText = newText;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
