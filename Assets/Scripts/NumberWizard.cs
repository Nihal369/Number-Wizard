using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	//Global variables
	int max,min,guess,numberOfTries=7;
	
	public Text text;

	// Use this for initialization
	void Start () {
		startGame();	
	}
	
	public void guessHigher()
	{
		min=guess;
		updateGuess();
	}
	
	public void guessLower()
	{
		max=guess;
		updateGuess();
	}
	
	void startGame()
	{
		max=1000;
		min=1;
		guess=Random.Range(1,1001);
		max+=1;
		text.text=guess.ToString();
	}
	
	void updateGuess()
	{
		guess=(max+min)/2;
		text.text=guess.ToString();
		numberOfTries-=1;
		if(numberOfTries<=0)
		{
			Application.LoadLevel("Win");
		}
	}
}