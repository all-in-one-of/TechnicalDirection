//Part 2 of the Questing Tutorial by GameGrind
//This script seems to have already been made beforehand. He's adding a few things to it
// to make the KillGoal script work
using UnityEngine;
using System.Collections;

public interface IEnemy
{
  int ID { get; set; }
  //He's adding this same line of code to his "slime" enemy script. 
  //Then, in that enemy script, he is making ID = 0 in the start function of it. 
  //He has a large script for slimes but for now I think I will keep it simple and just
  //  have this function in it. Anything he puts in I will add to make sure this functions
  //  properly. Hopefully. 
  //Anyway same principle could work for NPCs, apparently. It's good for a character identifier. 
  
  /* The following was already in the script? I'm going to comment it out for now
  If I need any of these, I will pull them out. I hope these won't be needed to make
  the questing scripts work.
  Spawner Spawner { get; set; }
  int Experience { get; set; }
  void Die();
  void TakeDamage(int amount);
  void PerformAttack();
  */

}
