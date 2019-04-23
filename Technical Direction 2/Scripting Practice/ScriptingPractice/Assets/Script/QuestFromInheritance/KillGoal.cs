//This script was made following a tutorial by GameGrind for Questing. 
//This script was made in the second part of his tutorial.

using System.Collections;
using System.Collections;
using UnityEngine;

public class KillGoal : Goal {
//He suggests making an identifier for the enemies?
//OH HE ALREADY HAS A SCRIPT FOR THIS UH... I'll Add it...?
//Script is an Interface called IEnemy (file name: IEnemy.cs)

//OK two scripts were made. 
  //Now we're gonna give the property of enemy ID
  public int EnemyID { get; set; }
  //We want to make sure that we assign a value that determines the enemy this KillGoal applies for
  //We want to make sure Kill Goal Inherits from 'Goal' instead of Mono Behaviour
  
  public KillGoal (int enemyID, string description, bool completed, int currentAmount, intRequiredAmount)
  {
    //As you can see, we are using items that are in the "Goal" script. 
    this.EnemyID = enemyID;
    this.Description = description;
    this.CurrentAmount = currentAmount;
    thisRequiredAmount = requiredAmount; 
  }
  
  //We're going to make an initilize method that will override the one in the Goal Script
  public override void Init()
  {
    base.Init();
    //This is a way to start an event listener so we know when any of the enemies die,
    //  and check if it's part of a quest. 
    
    /* OK so for this part he had a previous enemy death script, or just a script for combat.
    So he used this to set up an enemy listener
    CombatEvents.OnEnemyDeath += EnemyDied;
    */
  }
  
  void EnemyDied(IEnemy enemy)
  {
    //For when the enemy dies in the combat
    if (enemy.ID == this.EnemyID) //If the enemy ID is the enemy ID that we care about for the quest
    {
      //We want to increment the value and then Evaluate where we are in the quest. 
      this.CurrentAmount++;
      Evaluate();
    }
  }
}
