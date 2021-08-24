using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjecsManager : MonoBehaviour
{
    public GameObject Cone;
    public GameObject RoadWork;
    public List<GameObject> Coins;

    private int initAmount = 5;
    private int spawnInterval = 11;
    private int lastSpawnZ = 22;
    private int spawnAmount = 10;

    public List<float> zSlist;

    private void Start()
    {
        SpawnCoinsPrefs(50);
    }
    public void SpawnCoinsPrefs(int amount)
    {
        for (var i = 0; i < amount; i++)
        {
            int Randomint = Random.Range(0, zSlist.Count);
            if (Randomint == 1)
            {
                int RandomintCoin = Random.Range(0, Coins.Count);
                GameObject newCoin = Instantiate(Coins[RandomintCoin], new Vector3(zSlist[0], -0.18f, lastSpawnZ), Coins[RandomintCoin].transform.rotation);
            }
            else if (Randomint == 2)
            {
                int RandomintCoin = Random.Range(0, Coins.Count);
                GameObject newCoin = Instantiate(Coins[RandomintCoin], new Vector3(zSlist[1], -0.18f, lastSpawnZ), Coins[RandomintCoin].transform.rotation);
            }
            else if (Randomint == 3)
            {
                int RandomintCoin = Random.Range(0, Coins.Count);
                GameObject newCoin = Instantiate(Coins[RandomintCoin], new Vector3(zSlist[2], -0.18f, lastSpawnZ), Coins[RandomintCoin].transform.rotation);
            }
            lastSpawnZ += spawnInterval;
        }

    }
    /*
    public List<GameObject> obstacles;

    void Start()
    {
        for (var i = 1; i < initAmount; i++)
        {
           SpawnObstacles();
        }
    }
    public void SpawnObstacles()
    {
        for(int i = 0; i < spawnAmount; i++)
        {
            lastSpawnZ += spawnInterval;
            if (Random.Range(0, 4) == 0)
            {
                GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];
                Instantiate(obstacle, new Vector3(0, -0.18f, lastSpawnZ), obstacle.transform.rotation);
                if (Random.Range(0, 2) == 1)
                {
                    ObstacleCollectabelSpace space = obstacle.GetComponent<ObstacleCollectabelSpace>();
                    Instantiate(Coin, new Vector3(space.GetLane(), 0, lastSpawnZ + 5.5f), Coin.transform.rotation);
                }
            }
            else
            {
                if (Random.Range(0, 2) == 1)
                {
                    Instantiate(Coin, new Vector3(0, 0, lastSpawnZ + 1.5f), Coin.transform.rotation);
                }
            }
        }
    }*/
}