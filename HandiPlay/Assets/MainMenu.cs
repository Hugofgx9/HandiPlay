using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
	}

	public void QuitGame () 
	{
		Application.Quit();
	}

	    // Start is called before the first frame update
    void Start()
    {
     	   
    }
}
