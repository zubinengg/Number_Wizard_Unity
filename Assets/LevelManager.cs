using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public void LoadLevel (string LevelName)
	{
		Debug.Log ("Level Load requested for lvl: " + LevelName);
		Application.LoadLevel(LevelName);
	}
	
	public void QuitLevel ()
	{
		Debug.Log("Level quit requested");
		Application.Quit();
	}
}