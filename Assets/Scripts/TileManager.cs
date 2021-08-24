using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
   public GameObject TilePref;
   public GameObject centralTile;
   public float PlatfromsCount = 1;

   private float NewTileZ = 100;

  void Start(){
     for(var i = 1; i<10;i++){
       GameObject NewTile = Instantiate(TilePref);
       NewTile.transform.position = new Vector3(centralTile.transform.position.x, centralTile.transform.position.y, centralTile.transform.position.z +NewTileZ );
       NewTileZ += 100;
     }
  }

    public void AddPlatform()
    {
        GameObject.Find("GOManager").GetComponent<GameObjecsManager>().SpawnCoinsPrefs(8);
        GameObject NewTile = Instantiate(TilePref);
        NewTile.transform.position = new Vector3(centralTile.transform.position.x, centralTile.transform.position.y, centralTile.transform.position.z + NewTileZ);
        NewTileZ += 100;
    }
}