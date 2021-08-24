using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDataManager : MonoBehaviour
{
    public int coins;
    public Text coinsText;
    //Player Data Methods ---------------------------------------------
    public int GetCoins()
    {
        return coins;
    }
    public void AddCoins(int amount)
    {
        coins += amount;
        coinsText.text = coins.ToString();
       // SavePlayerData();
    }
    public bool CanSpendCoins(int amount)
    {
        return coins >= amount;
    }
    public void SpendCoins(int amount)
    {
        coins -= amount;
        coinsText.text = coins.ToString();
        // SavePlayerData();
    }
   /* static void LoadPlayerData()
    {
        playerData = BinarySerializer.Load<PlayerData>("playerAccountData.json");
        UnityEngine.Debug.Log("<color=red>[PlayerData] Loaded. </color>");
    }
    static void SavePlayerData()
    {
        BinarySerializer.Save(playerData,"playerAccountData.json");
        UnityEngine.Debug.Log("<color=red>[PlayerData] Saved. </color>");
    }*/
}
