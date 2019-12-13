﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class SceneLoader : MonoBehaviour
{
	int thisIndex; //index of current scene
	public void QuitGame()
	{
		Application.Quit();
	}
	public void LoadLevel(int index)
	{
		SceneManager.LoadScene(index);
	}

	public static void Victory()
	{
		SceneManager.LoadScene("VictoryScene");
	}
	public static void GameOver()
	{
		SceneManager.LoadScene("GameOver");
	}
	public static void Menu()
	{
		SceneManager.LoadScene("Menu");
	}

	public static void ReloadCurrentScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void LoadNextLevel()
	{
		// Debug.Log(thisIndex);
		if(thisIndex < SceneManager.sceneCountInBuildSettings - 1)
		{
			LoadLevel(thisIndex + 1);
		}
		else
		{
			// Debug.Log(SceneManager.sceneCountInBuildSettings);
			LoadLevel(0);
		}
	}

    public static int CurrentScene()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
