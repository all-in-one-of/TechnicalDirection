using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will stay on an object, waiting to trigger the dialogue.
public class TriggerText : MonoBehaviour {

  //This is calling the other class, TextArea, where it has the settings for the textbox
  public TextArea dialogue;

  //This should try to find the dialogue and how it can be triggered.
  public void TextTrigger ()
  {
    //I know there is a better method to use other than FindObjectOfType... Maybe ask Romrell
    //Regardless, this will find out TextManager.CS file, find the StartConvo Function, and pass in the 
      //variable we made here, dialogue, to it.
    FindObjectOfType<TextManager>().StartConvo(dialogue);
  }
}
