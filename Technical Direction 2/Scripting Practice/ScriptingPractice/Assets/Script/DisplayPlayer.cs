using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

//This script was made for figuring out how to make a QUESTING SYSTEM.
//In the original tutorial, Brackeys already had a "Display Player" Script on the Player Window
//However, ne never showed what was in that script. 
//I'm going to try to recreate what MIGHT have been in the script. And hopefully it works.
//Fingers crossed

public class DisplayPlayer : MonoBehaviour
{
    //You will first need to get the Player Window game object
    public GameObject playerWindow;

    //We're probably going to want to reference the player script, so we can get
    // any changes to health or experience.
    public PlayerQuestTut player;

    //Now identify the fields that will be changed according to what the player has.
    public Text health;
    public Text experience;
    public Text gold;

    //When the game starts, this script will grab the data from the player and
    // display it in the window
    private void Start()
    {
        health.text = player.health.ToString();
        experience.text = player.experience.ToString();
        gold.text = player.gold.ToString();
        
    }
    
    //When a fight occurs by pressing the button, the text will change.
    // I'm sure there's a better way to make it more streamline but this is what I got for now.
    public void DisplayChange()
    {
        health.text = player.health.ToString();
        experience.text = player.experience.ToString();
        gold.text = player.gold.ToString();
    }
}

