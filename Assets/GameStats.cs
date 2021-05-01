using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour {

    private bool gameEnd = false;
	// Use this for initialization
	void Start ()
    {
        if (gameEnd)

            return;

                if(PlayerStats.Lives <= 0)
            {
                EndGame();
            Application.Quit();

        }

    }
	
	void EndGame()
    {
        gameEnd = true;
        Debug.Log("GameOver");
        Application.Quit();
    }
}
