using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
//This script was used for the PlayerData script, learning how to make a save and load script.

  public int level = 3;
  public int health = 40;
  
  //These functions will be used for the button events. 
  
  //This will save the player's information
  public void SavePlayer()
  {
    SaveSystem.SavePlayer(this);
  }
  
  //This will load the data from the file to the player as a data type.  
  //Then the rest of the variables will be applied.
  public void LoadPlayer()
  {
    PlayerData data = SaveSystem.LoadPlayer();
    
    level = data.level;
    health = data.health;
    
    Vector3 position;
    position.x = data.position[0];
    position.y = data.position[1];
    position.z = data.position[2];
    transform.position = position;
    
  }
  

}
