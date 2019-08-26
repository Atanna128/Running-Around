using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class MapData 
{
    public int level;
    public int[] list = new int[288];
   
    public MapData()
    {

    }
    public MapData(int[] newlist,int level)
    {
        this.level = level;
        this.list = newlist;
    }
}
