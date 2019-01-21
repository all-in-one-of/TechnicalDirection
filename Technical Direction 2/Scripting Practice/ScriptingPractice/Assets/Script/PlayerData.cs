using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is used to help save the system.
// Using the video tutorial I found, the person suggests and ideal way to have save files is to make the save into a binary file
// so that it's not modified easily. 

// In the tutorial, the Player has 3 primary pieces of data. Their position, a script that has their level and their health

// Supposedly this means that the game can be saved in a file
[System.Serializable]
public class PlayerData {

  public int level;
  public int health; 
  public float[] position;
  //The reason that a float array is used is because a Vector3 isn't serializable, but a float is. 
  
  //To tell the class to get this information from the player, you will need a constructor
  //Constructors at like a set of functions
  
  //This will take in data from the player script & store it in the three variables. 
  public PlayerData(Player player)
  {
    level = player.level;
    health = player.health;
    //To get the player's position, you'll need to do sme additional work. 
    position = new float[3]; //This establishes how big the array is
    //The next lines will get a value from one of the transform axis from the player and store it in the array
    position[0] = player.transform.position.x;
    position[1] = player.transform.position.y;
    position[2] = player.transform.position.z;
    //Supposedly you can do something similar with Color variables
    
  }

}
