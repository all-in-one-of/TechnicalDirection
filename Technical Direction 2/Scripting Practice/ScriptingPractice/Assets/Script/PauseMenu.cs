using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//The SceneManagement helps you access other scenes in the project.

//Brackeys tutorial on Pause Menus give a good tutorial on how to make UI aesthetically pleasing in Unity

public class PauseMenu : MonoBehaviour {
  
  //This variable will keep track if the game is paused or not
  public static bool GameIsPaused = false;
  
  //This acts as a reference to the UI
  public GameObject pauseMenuUI;
  
  void Update ()
  { 
    // if the escape key was pressed
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      // if GameIsPaused is active/true, the game should resume again if the escape key was pressed
      if (GameIsPaused)
      {
        Resume();
      } else // if GameIsPaused is not true (aka: game is running), then hitting the escape key should pause it
      {
        Pause();
      }
    }
  }
 
 //Method where the game will resume after being run
 public void Resume()
 {
    //If the game was already paused, then this will deactivate the pause menu
    pauseMenuUI.SetActive(false);
    //This is setting the time of the game/world back to normal.
    Time.timeScale = 1f;
    GameIsPaused = false;
 }
 
 //Method where the game will be paused when it's being run
 void Pause()
 {
    //This will cause the UI to become active. Currently it should be disabled in Unity, I believe.
    pauseMenuUI.SetActive(true);
    //This next part will freeze time in the game so nothing will happen.
    //This is also used to create slow motion effects
    Time.timeScale = 0f;
    GameIsPaused = true;
 }
 
  //This Load Menu function was made so the game can go back to the main menu if selected. You can implement this once
  //you have a main menu of some kind.
 
 public void LoadMenu()
 {
    Debug.Log("Loading menu...");
    //Time.timeScale = 1f;
    //This should be put in once the main menu is in place, because it will resume time in the rest of the game.
    //After all, the game WAS paused, but now we don't want everything to be paused. 
    
    //SceneManager.LoadScene("Menu");
    //The tutorial suggests you don't hard code this, but instead create a variable for it.
    //Whatever is in Quotes is the name of the scene, so be sure it's accurate.
    //Also, be sure that the Scene you want to access is added into the build settings in "Scenes in Build"
 }
 
 //When run, the game will quit.
 public void QuitGame()
 {
    Debug.Log("Quitting game...");
    Application.Quit();
 }
 
}
