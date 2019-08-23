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
        //Debug.Log(path);
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
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    public static MapData LoadMap(string level)
    {
        MapData data = new MapData();
        string currentPath = "Assets/LevelJson/" + level + ".json";
        StreamReader stream = new StreamReader(currentPath);
        string json = stream.ReadToEnd();
        data = JsonUtility.FromJson<MapData>(json);
        stream.Close();
        return data;
    }

    public static void SaveMap(MapData data, string level)
    {
        string path = "Assets/LevelJson/" + level + ".json";
        string json = JsonUtility.ToJson(data);
        //StreamWriter stream = new StreamWriter(path); // dong nay gay ra bug :(
        Debug.Log(json);
        File.WriteAllText(path, json);
    }
}
