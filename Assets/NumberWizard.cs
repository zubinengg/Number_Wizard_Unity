using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

	// Use this for initialization
	int max ;
	int min ;
	int guess ;
	int maxGuessAllowed = 5;
	
	public Text text;
	
	void Start ()
	{
		StartGame ();	
	}
	
	void StartGame ()
	{
		max = 1000;
		min = 1;
		guess = Random.Range(min,max);
		text.text = guess.ToString()	;
	}
	
	void NextGuess ()
	{
		guess = Random.Range(min,max);
		text.text = guess.ToString();
		maxGuessAllowed -=1;
		if (maxGuessAllowed<=0)
		{
			Application.LoadLevel("Win");
		}
	}
	// Update is called once per frame

	public void GuessLower ()
	{
		max = guess;
		NextGuess ();
	}
	
	public void GuessHigher ()
	{
		min = guess;
		NextGuess ();
	}
}
