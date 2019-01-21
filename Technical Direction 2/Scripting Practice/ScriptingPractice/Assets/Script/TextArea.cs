using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Seralizable]
//This lets you embed a class with sub properties in the inspector.
//AKA: This lets the class show up in the inspector and be editable
//"You can use this to display variables in the inspector similar to how a Vector3 shows up in the inspector."
//https://docs.unity3d.com/ScriptReference/Serializable.html

public Class TextArea {

  //Define a variable where the NPC's Name can go
  public string npcName;
  
  //Defines how big the text area can be for the dialogue.
  //The first input (3) is the minimum amount of lines, and the last is the maximum
  [TextArea(1, 6)]
  
  //An array of how many lines an NPC will have.
  public string[] lines;
  
}
