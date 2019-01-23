using UnityEngine;
using System.IO;  //System.IO is what you want to use if you want to work with files on an operating system.
using System.Runtime.Serialization.Formatters.Binary;   //This will let you access the Binary Formatter to make a binary save file

//This script is used to help make a Saving System. 

//This is marked as a static class so that it can't be instantiated.
//You don't want multiple versions of your save system. 
public static class SaveSystem {

  public static void SavePlayer(Player player)
  {
    //Create a binary formatter that you can use. 
    BinaryFormatter formatter = new BinaryFormatter();
    //state where the file should be saved.
    string path = Application.persistentDataPath + "/player.fun";  //This will get a path on the data directory that won't suddenly change.
    
    //FileStream is a stream of data contained in a file. You can use a particular FileStream to read and write a file.
    FileStream stream = new FileStream(path, FileMode.Create);
    //FileMode. will help determine if you want to open a file, create a file, or append to an already existing file.
    
    //This helps the code run from the PlayerData class
    PlayerData data = new PlayerData(player);
    
    //Serialize means you're going to write data to the file. 
    formatter.Serialize(stream, data);
    
    //When you're done writing data to the file, you'll want to close it.
    stream.Close();
  }
  
  //This will load the data
  public static PlayerData LoadPlayer()
  {
    string path = Application.persistentDataPath + "/player.fun";
    
    if (File.Exists(path))
    {
      //First open up a BinaryFormatter
      BinaryFormatter formatter = new BinaryFormatter();
      //Open up a file stream
      FileStream stream = new FileStream(path, FileMode.Open);
        //FileMode.Open should open the file
        
      //Read from the stream. The Deserialize should take the binary format and turn it back to the readable format.
      //And also store that data into a data variable
      // you'll need to cast the data as well so it becomes a type of data you are working with, which is why you us 'as' at the end. 
      PlayerData data = formatter.Deserialize(stream) as PlayerData;
      
      //Always close the file stream
      stream.Close();
      
      return data;
    } else
    { //If the file isn't found, it returns an error message.
      Debug.LogError("Save file not found in " + path);
      return null;
    }
  }
  
}
