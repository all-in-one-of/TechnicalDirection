//This time, we are following a tutorial from GameGrind called "Quest Goal" on YouTube.
//We were directed here from the original Questing tutorial we did because
// this tutorial is done through inheritence, which probably makes the other scripts function
// much better.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal {
// No MonoBehaviour because we won't be using anything that is coming from MonoBehaviour

  //We need to compare the current amount the player has for a quest with the required amount
  //When we hit that, that part of the Quest is completed.
  //Sometimes Quests could have multiple goals, so just finishing one requirement
  //  may not complete a quest.
  
  //OK RIGHT OFF THE BAT. He made something called a "property". He made it a string property
  //Properties seem to be used "to access the member variables (fields) in a class"...?
  public string Description { get; set; }
  //This describes what the goal is. 
  
  public bool Completed { get; set; }
  //Sees if the Quest was completed
  
  public int CurrentAmount { get; set;}
  //Tracks the current amount for a goal
  
  public int RequiredAmount { get; set;}
  //What the required amount is for a goal
  
  //There are a few methods that you should make
  //Evaluate method that determines if the quest should be completed
  //Complete method
  //And an Initilization method to initialize the goal in the list. 
  //When a goal is added, we want to be able to track it after all.

  //The Initialization Method. He said this will most likely be overridded
  //After digging into it, it seems that the "virtual" is used to override a base class member
  //  with the members of a child class. This sounds like what he was trying to be done.
  //  This also makes sense if it allows each quest to be different. 
  public virtual void Init()
  {
    //Basically a default? IDK
    //He put "default init stuff" so i'm assuming this method is gonna change. 
    //I have no idea how this works.
  }
  
  //This will see if the current amount is greater than or equal to the required amount
  public void Evaluate()
  {
    if (CurrentAmount >= RequiredAmount)
    {
      Complete(); //The method that will actually tell if the goal was completed. 
    }
  }
  
  public void Complete()
  {
    Completed = true;
    //This refers to the completed property we made
  }
}
