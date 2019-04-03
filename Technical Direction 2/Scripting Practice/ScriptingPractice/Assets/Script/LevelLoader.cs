// The following was done by following Brackey's tutorial on making a Loading Bar in Unity

using System. Collections;
using UnityEngine;
//To access the "Scene Manager" feature in unity, you need to add the following
using UnityEngine.SceneManagement;
//To access the UI features in Unity, add the following
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

  //This will reference the UI canvas of the loading screen
  public GameObject loadingScreen;
  public Slider slider;
  
  //Text used to change the Progress Percentage Text
  public Text progressText;


  //to specify what level to load, you can either use a string and the level name, or the index of the level
  public void LoadLevel(int sceneIndex)
  {
    
    //LoadSceneAsync will load the scene asyncroniously (however that's spelled),
    // so the current scene and the behaviors in it are running while the next scene is being loaded. 
    //This returns an object of the operation, called AsyncOperation, and you can use it to access properties that are storing info
    // about the operation
    //The AsyncOperation is like a Coroutine, so to get the information, you need to use a coroutine
    
    StartCoroutine(LoadAsynchronously(sceneIndex));
    
    /*Unity loads things differently. In the tutorial, we saw that the progress went from 0 to 0.9 and was finished loading.
    Whenever Unity ywants to load something it does things in two stages.
    In the first stage, the loading stage, unity loads the assets from memory into the next scene. Long story short, this is
      what should be represented in the loading bar. 
    The second stage is the activation stage. Unity will delete the olds stuff we don't need anymore and replace them with new ones.
    
    The loading stage is done in increments from 0-0.9. In the activation stage, unity goes from .9-1
    
    So some math needs to be done so that 0 to 0.9 are numbers we can understand
    */
    
    // Once the math and variables are in place, you should make a UI
    /*
    The default value in a slider goes from 0 to 1, and because of the mathh we did, this matches the values we will get.
    
    Keep in mind that the bar value won't go COMPLETELY full on the slider.
    Go into the settings in unity so that you select the bar it self and move it when the value is one
    
    You can add a percentage text as well to the loading bar.
    */
  }
  
  IEnumerator LoadAsynchronously (int sceneIndex)
  {
    AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
    //LoadSceneAsync will load the scene asyncroniously (however that's spelled),
    // so the current scene and the behaviors in it are running while the next scene is being loaded. 
    //This returns an object of the operation, called AsyncOperation, and you can use it to access properties that are storing info
    // about the operation
    //The AsyncOperation is like a Coroutine, so to get the information, you need to use a coroutine
    
    //When you start loading the scene, you can set the loading scene to active
    loadingScreen.SetActive(true);
    
    while (operation.isDone == false)
    {
    
      float progress = Mathf.Clamp01(operation.progress / .9f);
      //Clamp is an operation between 0 and 1. The variable of the operation.progress will be divided by .9 (the final value previously)
      // and convert into a value so that .9 will display as 1, making more sense. 

      Debug.Log(progress);

      
      slider.value = progress; //The value we get from the math we did above will change the value of the slider
      progressText.text = progress * 100f + "%";  //The text in the UI will change to this function.
      //You multiply the value of the progress bar by 100 to get a percentage and then add the percentage symbol
      
      yield return null; // this will wait until the next frame before it continues
    }
    
  }
}
