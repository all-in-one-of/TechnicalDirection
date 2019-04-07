// This script was made by following a "QUESTING SYTEM" tutorial by Brackeys
// This is the second script he made.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour 
{
  //The Quest giver needs a quest to give away
  public Quest quest; //This reference the quest you just made. 
  
  //It could be good to make sure the Quest Giver can actually reference the player so it has someome to give the quest to.
  
  public PlayerQuestTut player; //Referencing the player script that was previously made.
  //In unity, drag the Player object into the right field. ... I legit forget how it's described. 
  
  //Once the 'Quest.cs' script is serializable, you can go into Unity and input the quest information into the fields that show up
  
  //We need a script that will open up the queset window. But we also need a reference to it, as well as other parts of the window
  public GameObject questWindow;
  public Text titleText;
  public Text descriptionText;
  public Text goldText;
  
  public void OpenQuestWindow()
  {
    questWindow.SetActive(true);
    
    titleText.text = quest.title;
    descriptionText.text = quest.description;
    experienceText.text = quest.experienceReward.ToString(); // this needs to turn into a string because the original value was an int.
    goldText.text = quest.goldReward.ToString();
    // In Unity, you drag in the right values from the Quest UI into thee fields that appear on the Quest Giver Empty Object
    
    //Add an OnClick event on the "Quest Button" that was in the PlayerWindow UI and put in the OpenQuestWindowFunction
    //Using a button is for simplicity. You can probably use an event system elsewhere that will let the quest pop up.
    //Honestly a button seems like a good way to at least test the system.
    
  }
  
  //We now need a funciton to accept the quest.
  public void AcceptQuest()
  {
    questWindow.SetActive(false);
    quest.isActive = true;
    //You wwant to be able to give the quest to the player. 
    //Go back to the Player script and let it access the "Quest" script
    player.quest = quest; //AKA: the quest in the player script is the quest. 
    /*  In the tutorial, Brackeys states that the method shown in the tutorial will only have one quest active at a time.
    if you want multiple quests... in the Player script, you need to make the 'quest' a list instead so you can add quests at runtime.
    */
    
    //On the AcceptButton in the UI, do an onClick event that will access this function.
    //When the button is pressed, the quest will transfer to the player. If you check the gameObject Player you'll see the quest info.
    
    //WE NOW NEED to make sure the player can work towards completing the quest. A seperate script will be made. 
    //"QuestGoal.cs" has been made. 
  }
  
}
