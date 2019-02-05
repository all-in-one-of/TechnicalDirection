using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //lets you manage scenes for your build

// First script made for Brackeys' "Start Menu Tutorial". 
// He starts off the tutorial by making a UI in Unity 

public class MainMenu : MonoBehaviour {

  // Activates when "play" is pressed
  public void PlayGame()
  {
    // You can specify what to load in parenthesis, but you can also load the next level in the queue.
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // Remember, the game scene should be next on the list in the build settings
  }
  
  public void QuitGame()
  {
    // Application won't quit in the unity editor, so we add a Debug to show the funciton works
    Debug.Log("Quitting Game...");
    Application.Quit();
  }
  
  // The Option Menu should be a canvas available in the current scene. It shouldn't have to load anything.

}
