using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SavePlayer(PlayerScript player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.mydb";
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
        MapData data = new MapData();
        string currentPath = Application.dataPath + "/LevelJson/" + level + ".json";
        //Debug.Log(currentPath);
        //StreamReader stream = new StreamReader(currentPath);
        //string json = stream.ReadToEnd();
        //data = JsonUtility.FromJson<MapData>(json);
        //FileStream stream = new FileStream(currentPath, FileMode.Open);
        //string log = File.ReadAllText(currentPath);
        //data = JsonUtility.FromJson<MapData>(log);
        //stream.Close();
        


        return data;
    }

    public static void SaveMap(MapData data, string level)
    {
        string path = Application.dataPath + "/LevelJson/" + level + ".json";
        string json = JsonUtility.ToJson(data);
        
        Debug.Log(json);
        File.WriteAllText(path, json);
        
    }
}
