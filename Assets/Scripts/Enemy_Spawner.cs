using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject coin;
    public GameObject[] islands;

    void Start()
    {
        islands = GameObject.FindGameObjectsWithTag("land");

        for (int i = 0; i < islands.Length; i++)
        {
            Vector3 position = islands[i].transform.position + new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
            Instantiate(enemy, position, Quaternion.identity);
            position = islands[i].transform.position + new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
            Instantiate(enemy, position, Quaternion.identity);
            position = islands[i].transform.position + new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
            Instantiate(coin, position, coin.transform.rotation);
        }
    }
}
