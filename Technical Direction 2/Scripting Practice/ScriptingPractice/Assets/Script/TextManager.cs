using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

  //variable that will keep track of all the sentences in the dialogue. 
  private Queue<string> sentences;
  // 'Queue' will need 'using System.Collections;' to work properly
  // Queue's are like a list except different; a FIFO collection (First In, First Out)
  // This is a way to put in all the sentences we want to use into the Queue
  // As you go through the text it should help load sentences until the end of the queue.

  // This variable will refer to the 'text' feature you will see in a UI. 
  public Text nameText; //npcName
  public Text messageText; //message of the NPC
  
  //Public Animator
  public Animator animate;
  
  //Bool if the dialogue is moving
  public bool textGoing = false; 
    
  void Start() 
  {
    sentences = new Queue<string>();
  }
  
  //TThis function should be placed on a button event, where when the button is pressed, dialogue will begin. 
  public void StartConvo (TextArea dialogue)
  {
    animate.SetBool("IsOpen", true);
    
    //Test this at the school to be sure everything works properly.
    //Later you can add it to an event so it'll trigger. 
    Debug.Log("Starting conversation with " + dialogue.npcName);
    
    //This will change the text where the NPC's name should go, thereby displaying the NPC's name in the UI
    nameText.text = dialogue.npcName;
    
    //This will clear any bit sof dialogue that were used previously. 
    sentences.Clear();
    
    //Go through each sentence in your array
    foreach (string sentence in dialogue.lines)
    {
      //Queue up a sentence the loop is currently looking at.
      sentences.Enqueue(sentence);
    }
    //Call this function so it will display the next message
    DisplayNextMessage();
  }
  
  //The DisplayNextMessage should be placed on the button that will continue an NPC's message
  public void DisplayNextMessage()
  {
    
    //First, check if there are more sentences in the queue
    //If the number of sentences left in the queue is 0, then the dialogue will end. 
    if (sentences.Count == 0)
    {
      EndDialogue();
      //Placing return here will allow you to exit out of the entire function. 
      return;
    }
    
    //IF YOU WANT THE DIALOUGE TO MOVE, you'll need to add a Coroutine
   /*
   StopAllCoroutines();
   StartCoroutine(TypeSentence(sentence));
   
    //This next function should be outside of the function
   IEnumerator TypeSentence (string sentence)
   {
    messageText.text = "";
    foreach (char letter in sentence.ToCharArray())
    {
      messageText.text += letter;
      yield return null;
    }
   }
   
   */
    if (textGoing == false)
    {
      //If there are still sentences left, this will get the next sentence in the Queue
      //Store the next sentence in a string variable
      string sentence = sentences.Dequeue();
    
      //This next part will change the text in the game to the string variable we just made
      messageText.text = sentence;
      //This will start the moving sentence function.
      StartCoroutine(TypeSentence(sentence));
    }else if (textGoing == true)
    {
      //StopAllCoroutines will stop any coroutine that is active, preventing overlap.
      StopAllCoroutines();
      textGoing = false;
    } 
    
    
  }
  
  IEnumerator TypeSentence (string sentence)
  {
    //This will start the message as Empty. 
    messageText.text = "";
    //For each letter/character in the array, it will add that to the message that will be displayed.  
    foreach (char letter in sentence.ToCharArray())
    {
      messageText.text += letter;
      //Create a bool that will indicate when the coroutine is active. This will be used later when the dialogue is running.
      textGoing = true;
      
      //Change text speed by:
      //yield return new WaitForSeconds(0.1f);
      yield return null;
      
    }

    textGoing = false;
  }
  
  //Function that will stop the dialogue all together
  void EndDialogue()
  {
    animate.SetBool("IsOpen", false);
    Debug.Log("End of conversation.");
  }
}
