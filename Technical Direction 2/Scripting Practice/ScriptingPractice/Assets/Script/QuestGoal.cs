// This script was made by following a "QUESTING SYTEM" tutorial by Brackeys
// This is the third script he made.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
  //Quests could have different types of goals. 
  //Depending on the type of goal, there are different actions you could take. 
  //Apparently there are different ways to define this, but the tutorial by Brackeys said he's going to use Enums for this. 
  //He mentioned another way to do this is by inheritence, which he left a link to another series about it in the video.
  //This could be worth checking out and breaking it down to understand the process better. 
  
  //After creating the enum fuction differentiating between the types of quests
  public GoalType goalType;
  
  //These next variables are a way of measuring how the quest is going
  public int requiredAmount;
  public int currentAmount;
  
  //This function will check to see if a quest is completed. 
  public bool IsReached()
  {
    return (currentAmount >= requiredAmount);
    //If the currentAmount equals to or exceeds the required amount, then the function will return true. If not, it's false. 
  }
  
   //HELLO WE'RE WORKING ON MAKING SURE THE PLAYER CAN COMPLETE A GOAL BY ADDING THE RIGHT VARIABLES TO THE REQUIRED AMOUNT
  //This first one is for a "killing" quest.
  public void EnemyKilled()
  {
    //This shoud only happen if the Goal Type is "Kill"
    if (goalType == GoalType.Kill)
    {
      currentAmount++;
    } //An If statement could also be good if you want to make sure only enemies of a certain type are killed.
  }
  
  //This second one is if the quest is a "gathering" quest
  public void ItemCollected()
  {
    //This should only happen if the Goal Type is "Gathering"
    if (goalType == GoalType.Gathering)
    {
      currentAmount++;
    } // Once again, this could also be ideal if you need only a certain item collected.
  }
}

//Defining Different types of Quests
//I'll be honest, this is the first time I've ever used an enum function in my 6 years here at UVU.
public enum GoalType
{
  Kill,
  Gathering,
  //He ALMOST put in Escort but he deleted it. I thought it was funny, and proof that EVERYONE hates escort missions. 
}
