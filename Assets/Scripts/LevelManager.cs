﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public void loadLevel(string level)
	{
		print("Request to load level "+level);
		if(level=="Game")
		{
			Application.LoadLevel(level);
		}
	}
	
	public void quitGame()
	{
		print ("Quiting game");
		Application.Quit();
	}
}
