using UnityEngine;
using System.Collections;

public class LevelManager2 : MonoBehaviour {
	public void changeLevel(string level)
	{
		print("Request to load level");
		Application.LoadLevel(level);
	}
}
