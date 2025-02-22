using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemy;
    private int enemy_count;
    public GameObject coin;
    public GameObject[] islands;

    void Start()
    {
        islands = GameObject.FindGameObjectsWithTag("land");

        for (int i = 0; i < islands.Length; i++)
        {
            enemy_count = Random.Range(0, 2);
            for (int xi = 0; xi < enemy_count; xi++)
            {
                Vector3 position = islands[i].transform.position + new Vector3(Random.Range(0, 2), 2, Random.Range(0, 2));
                Instantiate(enemy, position, Quaternion.identity);
                position = islands[i].transform.position + new Vector3(Random.Range(0, 1), 1, Random.Range(0, 1));
                Instantiate(coin, position, coin.transform.rotation);
            }
        }
    }
}
