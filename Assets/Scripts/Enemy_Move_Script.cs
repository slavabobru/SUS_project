using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move_Script : MonoBehaviour
{
    private Transform plPos;
    private Vector3 direction;
    public float enSpeed = 3f;
    public float attackRng = 3f;
    private float plDistance;

    void Start()
    {
        plPos = GameObject.Find("SUS");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
