using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max=1000;
	int min=1;
	int guess=500;

	// Use this for initialization
	void Start () {
		startGame();	
	}
	
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("up"))
		{
			//print("Up key pressed");
			min=guess;
			updateGuess();
		}
		
		else if(Input.GetKeyDown("down"))
		{
			//print("Down key pressed");
			max=guess;
			updateGuess();
		}
		
		else if(Input.GetKeyDown("return"))
		{
			print("I won,Woohu :P");
			startGame();
		}
	}
	
	
	void startGame()
	{
		max=1000;
		min=1;
		guess=500;
		print ("=============================");
		print ("Welcome to Mathematic Horcrux");
		print("Pick a number between 1 and 1000,but dont tell me");
		
		print("The maximum number you can pick is "+max);
		print("The minimum number you can pick is "+min);
		
		//Updated max to 1001,so that user can choose 1000
		max+=1;
		
		print("Is your number greater or lesser than "+guess);
		print("Up for greater,Down for lower,Enter for equal");
	}
	
	void updateGuess()
	{
		guess=(max+min)/2;
		print("Is your number greater or lesser than "+guess);
		print("Up for greater,Down for lower,Enter for equal");
	}
}