using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour {

  //variable that will keep track of all the sentences in the dialogue. 
  private Queue<string> sentences;
  // 'Queue' will need 'using System.Collections;' to work properly
  // Queue's are like a list except different; a FIFO collection (First In, First Out)
  // This is a way to put in all the sentences we want to use into the Queue
  // As you go through the text it should help load sentences until the end of the queue.

  void Start() 
  {
    sentences = new Queue<string>();
  }

}
