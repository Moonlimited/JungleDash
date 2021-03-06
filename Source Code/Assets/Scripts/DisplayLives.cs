﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour {

	//declare text and lives variables
    private Text text;
    private int lives;

	// Use this for initialization
	void Start () {
		//assign text component
        text = GetComponent<Text>();
		//initialize color display
        ColorLives();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Getting lives from the playerprefs, and displays it as long as the player has life
        lives = PlayerPrefsManager.GetLives();
        if (PlayerPrefsManager.GetLives() >= 0)
        {
            text.text = "Lives: " + lives.ToString();
        }
        
		//update color of lives text
        ColorLives();
    }

    private void ColorLives()
    {
        //Color gradient for lives text depending on lives level
        if (lives == 3)
        {
			//green
            text.color = new Color(76.0f / 255.0f, 175.0f / 255.0f, 80.0f / 255.0f);
        }
        else if (lives == 2)
        {
			//yellow
            text.color = new Color(255.0f / 255.0f, 235.0f / 255.0f, 59.0f / 255.0f);
        }
        else
        {
			//red
            text.color = new Color(201.0f / 255.0f, 0.0f / 255.0f, 0.0f / 255.0f);
        }
    }
}
