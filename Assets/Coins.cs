using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("GameDataManager").GetComponent<GameDataManager>().AddCoins(1);
            Destroy(this.gameObject);
        }
        Debug.Log(other);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
