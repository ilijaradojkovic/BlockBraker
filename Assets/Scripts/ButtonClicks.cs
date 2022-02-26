using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClicks : MonoBehaviour
{
  public void loadPlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    
  public void loadMenuStart()
    {
        SceneManager.LoadScene(0);
    }
}
