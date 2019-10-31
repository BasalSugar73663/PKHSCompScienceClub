using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour {

	public void open_game()
    {
        SceneManager.LoadScene("First Scene");
    }
	
    public void close_game()
    {
        Application.Quit();
    }
	
}
