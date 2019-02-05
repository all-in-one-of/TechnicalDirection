using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; //Allows you to edit audio stuff in the script
using UnityEngine.UI;

// This is based on the Tutorial you watched from Brackeys, where he made an Option/Settings Menu
// Before you implement this script, you should make the UI for the Option Menu and make sure the buttons, sliders, and dropdown menus work

// He placed this script on the canvas
public class SettingsMenu : MonoBehaviour {

  //Making a reference to the volume mixer
  public AudioMixer audioMixer;
  
  //variable that will reference UI element
  public Dropdown resolutionDropdown;
  
  Resolution[] resolutions;

  void Start()
  {
    //In this method, gather information about what resolutions can be used at our disposal.
    //Get an Array of all the resolutions and store them in a variable.
    resolutions = Screen.resolutions;
    
    //when you get a list of resolutions, youw ant to clear out the placeholder resolutions
    resolutionDropdown.ClearOptions();
    
    //You'll need to turn the resolutions array into formatted strings
    //Things to note: the size of a list can be changed. 
    List<string> options = new List<string>();
    
    //Make the first resolution match the one that was given
    int currentResolutionIndex = 0;
    for (int i=0; i < resolutions.Length; i++)
    {
      // Width x Height
      // i represents the index. So the width and height of the resolution at all the indexs will be made into strings
      string option = resolutions[i].width + "x" + resolutions[i].height;
      
      //Add() will add the element we just made to the UI
      options.Add(option);
      
      //if the current resolution is the same one as the resolution the user is using, then set it.
      // QUICK NOTE: A commenter mentioend that you should compare with Screen.width & Screen.height instead of Screen.currentResolution.width
      // because it will compare the resolution of the window in case the scene changes. 
      if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
      {
        currentResolutionIndex = i;
      }
    }
    
    // Adding variables in the options list into the menu
    resolutionDropdown.AddOptions(options);
    //Changing the Resolution Value
    resolutionDropDown.value = currentResolutionIndex;
    resolutionDropdown.RefreshShownValue();
  }

  // Creating a method to affect the volume. The value that is taken in is based on the value of the slider
  // Whenever the slider is moved, this function will get called and Unity will feeed in the current value.
  public void SetVolume(float volume)
  {
    //Displaying the current variable of the volume
    Debug.Log(volume);
    
    //Add an AudioMixer to the game 
    //It will show different layers ofvolume fo the game.
    //You want to expose the volume parameter in this script.
    //There's a setting under Attenuation. If you click volume, you might see somethingn like "expose volume of master to script"
    //Rename MyExposeParam to volume.
    
    //Reference the audio mixer
    audioMixer.SetFloat("volume", volume); 
    // THIS IS REFERENCING THE 'volume' IN THE ACTUAL AUDIOMIXER. 
    //Make sure when ereferencing the name in the parenthesis is the same as the one you gave in the Audio Mixer
    // The second volume in that line of code is the value you want to set the volume to, which we got in the SetVolume Function
  }
  
  //The Next part relates to the quality of the game.
  //Just be sure they match with the graphic settings in Unity. 
  //In the Quality Settings in Unity, you can see what quality levels are there.
  //The 'int' is going to be the index of the element we chose. Low will be 0, for example
  public void SetQUality(int qualityIndex)
  {
    //Access the QualitySettings. The qualityIndex will take in the values of the drop down menu already.
    //If that's the case, it seems important to ahve the first dropdown be Low, then Medium, then High, similar to how it is in Unity
    QualitySettings.SetQualityLevel(qualityIndex);
  }
  
  //Full Screen toggle
  //It will take in a Bool because it's just checking if it is fullscreen or not
  public void SetFullscreen (bool isFullscreen)
  {
    //The value of isFullscreen should be dependent on if the box is checked or not. If you attach it to an event in Unity you should be good,
    Screen.fullScreen = isFullscreen;
    //THis won't change in the editor, btw. It will happen in the game.
  }
  
  //Resolution
  //Making the resolution will be a bit difficult because it depends on the screen. 
  //The options he has in the menu are placeholder.
  //Unity can help figure out what resolutions will work. 
  //You need to make sure you have the correct options.
  //This function will actually update the resolution of the screen. 
  public void SetResolution (int resolutionIndex)
  {
    // Find out what resolution was selected.
    // Get the width and the height from the resolution array
    Resolution resolution = resolutions[resolutionIndex];
    Screen.SetResolultion(resolution.width, resolution.height, Screen.fullScreen);
  }
}
