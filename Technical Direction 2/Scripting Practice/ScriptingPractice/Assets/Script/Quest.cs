// This script was made by following a "QUESTING SYSTEM" tutorial by Brackeys
// This is the first script he made. 

// To start out, he had a Canvas with a player window that displayed information about the player.
// It had details like "Heath Text", "Experience Text", and "Gold Text"
// These variables will usually change after a quest is completed, so it makes sense that they are here.

// There is an Empty Game Object that represents the Player, where it contains the data for the Health, Experience, and the Gold.
// He made a player script for this. I will Make a "Player.CS" script that reflects what he had. 

// Brackeys disables a "QuestWindow" Ui where it has the 'Title', the 'Description', 
// A SwordImg (i assume a graphic), a CoinsImg (another graphic), 'Experience', 'Gold', and an AcceptButton

//And now, we begin coding
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is an instance where you don't want to use MonoBehaviour
// If you want this class to be seen in Unity, we need to Serialize it.
[System.Serializable]
public class Quest
{
  //Make a variable that will show if a quest is currently active or not
  public bool isActive;
  
  //You need to establish variables that will come up when a quest is displayed.
  public string title;
  public string description;
  public int experienceReward;
  public int goldReward; 

  //Now you'll need a way for the player to get the quest. 
  //He uses an empty object to act as a Quest Giver
  //"QuestGiver" script made. 

  //WE'RE COMING IN FROM THE 3RD SCRIPT "QuestGoal" now.
  //We're making sure that the quest goal can be accessed from the quest script. 
  public QuestGoal goal;
  
  //Now in Unity there should be more fields on the Quest Giver Script
  //You should be able to select what the Goal Type is, and specify what the required amount is. 
  //Now if we want to make sure the 'currentAmount' changes as the player goes along, we need to edit the Player script a bit.
  //Go over to Player.cs
  
  //HELLO WE'RE MAKING A COMPLETE FUNCTION SO THAT, WHEN THE GOAL IS REACHED, WE CAN TELL IT'S COMPLETED.
  public void Complete()
  {
    isActive = false; //To show the quest will no longer be active
    Debug.Log(title + " was completed!"); //Text showing The Quest you had was completed
  }
}
