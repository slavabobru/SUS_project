using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float vertical;
    public int speed = 15;
    public GameObject player_st_pos;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
            // transform.Translate(Vector3.back * Time.deltaTime * speed * horizontal);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
            player.transform.position = player_st_pos.transform.position;
            player.transform.rotation = player_st_pos.transform.rotation;
        }
    }
    
}
