//Used for making a Questing system in the tutorial.
//The original script has a lot more in it so I'm hoping by only adding
//  the elements that were used for making a questing system, the overall system will work. 
using UnityEngine;
using System.Collections.Generic;
using System;

public class Slime : MonoBehaviour, IEnemy
{
  //Adding property value to the Sline
  public int ID { get; set; }
  
  void Start()
  {
    ID = 0;
  }
  
}
