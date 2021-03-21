using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool Is_game_over = false;
     
     public void Game_over() 
     { 
         Is_game_over = true;
     }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.R) && Is_game_over == true) 
        { 
            SceneManager.LoadScene("GAme");
        }
        
    }
}
