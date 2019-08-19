using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData 
{
    public int coin;

    public PlayerData(PlayerScript player)
    {
        coin = player.coin;
    }
}
