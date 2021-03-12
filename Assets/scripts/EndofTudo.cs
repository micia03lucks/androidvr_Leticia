using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndofTudo : MonoBehaviour
{
    
    public void endOfgame()
    {
        //Debug.Log("HIT");
        //Application.Quit();
        SceneManager.LoadScene("final");
    }
    public void reallyEndOfGame()
    
    {
        
     Application.Quit();

    
    }

}
