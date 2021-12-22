using UnityEngine;
using System.IO; //we want to work with files
using System.Runtime.Serialization.Formatters.Binary; //this will allow us to access the binary formatter

public static class SaveSystem  //a static class is just a class that can't be instantiated because we don't want to accidentally create multiple versions of our save system
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/player.fun";   //"C:/System/";//this path work on Window but doesn't work a Mac,androis,ios 
        //unity has a really handy function called application.persistentDataPath and this is just going to get a path to a data directory on the operatig system that  isnt going to suddenly change then we can add anything to this
        FileStream stream = new FileStream(path, FileMode.Create); //we have created this file on our system an we are ready to write to it so

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data); //which means that we are going to write data to the file
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.fun";

        if(File.Exists(path)) //varsa
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
