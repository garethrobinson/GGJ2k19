﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour {
    Image bg;
    Text txt;
    int textSpeed = 2;
    string targetText = "";
    string currentText = "";
    int count = 0;
    public void Init( DialogueManager dm ) {
        bg = GetComponent<Image>();
        bg.color = dm.textBoxColor;
        txt = transform.GetChild( 0 ).GetComponent<Text>();
    }
    public void SetText( string target ) {
        count = 0;
        targetText = target;
    }
    private void Update() {
        if ( targetText.Length > 0 ) {
            count += textSpeed;
            txt.text = targetText.Substring( 0, Mathf.Min( count, targetText.Length ));
        }
    }
}
