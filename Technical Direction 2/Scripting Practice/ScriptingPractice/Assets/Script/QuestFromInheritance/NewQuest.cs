//part 3 in the Questing System tutorial by GameGrind
//Remember, while you are following along with the tutorial, many things will probably need
//  to be edited or left out. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewQuest : MonoBehaviour
{
  //We need a list of goals, reward options, maybe the name of the quest, etc.
  
  public List<Goal> Goals { get; set; }
  //You can initialize the goals with the... Auto implementing property??
  //Oh apparently you need to change the Scripting Runtime Version to .NEt 4.6 to make this work???
  //I miss the old tutorial guy. I felt like I was understanding coding much better. 
  //Either way, we'll just have to see how this turns out. 
  
  public string QuestName { get; set; }
  public string Description { get; set; }
  public int ExperienceReward { get; set; }
  //public Item ItemReward { get; set; }
  //Above seems to be from a script that's already written
  public bool Completed { get; set; }
  
  //first method is going to check all the goals in the quest to see if everything is completed
  public void CheckGoals()
  {
    //We're gonna be using the Linq Method Namespace?
    //Essentially it's a query library where we can make queries over a collection of data
    //Like a collection of goals
    //we can make a condition with it.
    
    /*if (Goals.All(g => g.Completed))//if anything in the Goal's list is not completed, the quest is not completed
    {
      Complete(); //This will run the method whenever all the goals are completed
    }
    
    void Complete()
    {
      Completed = true;
    } */
    
    //OK HE MADE IT SIMPLIER??? I do not like tutorials like these where they change everything
    //  like "Oh wait this is better"
    //Let me know in advanced please.
    
    //Here's what he changed it to. He got rid of the if statement and the Complete() void statment
    
    Completed = Goals.All(g => g.Completed);
    
    //Adding this to say if the quest is completed, a reward should be given. 
    if (Completed) GiveReward();
  }
  
  //We want to have  Give Reward Method
  void GiveReward()
  {
    /*
    if (ItemReward != null)
    {
      //Once again, using a script that we do not have.
     
      InventoryController.Instance.GiveItem(ItemReward);
      Debug.Log("Reward?");
    } 
     */
  }
}
