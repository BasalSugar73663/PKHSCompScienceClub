using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour {

	public void open_game()
    {
        SceneManager.LoadScene("Lawn Scene");
    }
	
    public void close_game()
    {
        Application.Quit();
    }

    public void suh_dude()
    {
        SceneManager.LoadScene("Main Menu");
    }
	
}
