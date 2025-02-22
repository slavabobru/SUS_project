using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadly_Script : MonoBehaviour
{
    public GameObject GameoverScreen;
    public GameObject player_st_pos;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Deadly"))
        {
            player.transform.position = player_st_pos.transform.position;
            player.transform.rotation = player_st_pos.transform.rotation;
            GameoverScreen.SetActive(true);
        }
    }
}
