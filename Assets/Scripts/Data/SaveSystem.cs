﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SavePlayer(PlayerScript player)
    {
        string path = Application.persistentDataPath + "/player.mydb";
        BinaryFormatter formatter = new BinaryFormatter();        
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);
        formatter.Serialize(stream, data);        
        stream.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.mydb";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data =  formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            stream.Close();
            return null;
        }
        
    }

    public static MapData LoadMap(string level)
    {
        string currentPath = Application.persistentDataPath +   "/" + level + ".map";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(currentPath, FileMode.Open);
        MapData data = formatter.Deserialize(stream) as MapData;
        stream.Close();
        return data;
        
    }

    public static void SaveMap(MapData data, string level)
    {
        string path = Application.persistentDataPath + "/" +  level + ".map";       
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, data);
        stream.Close();
    }


    public static void GenerateMap(MapData data, string level)
    {
        string path = Application.persistentDataPath + "/" + level + ".map";
        if (!File.Exists(path))
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            stream.Close();

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Create);
            formatter.Serialize(fileStream, data);
            fileStream.Close();
        }      

    }
}
