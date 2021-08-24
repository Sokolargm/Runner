using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIsStartNewPlatform : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("Tile Manager").GetComponent<TileManager>().AddPlatform();
        }
    }
}
