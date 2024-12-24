using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move_Script : MonoBehaviour
{
    private Transform plPos;
    private Vector3 direction;
    public float enSpeed = 4f;
    public float attackRng = 5f;
    private float plDistance;

    void Start()
    {
        plPos = GameObject.Find("SUS").transform;
    }

    // Update is called once per frame
    void Update()
    {
        plDistance = Vector3.Distance(transform.position, plPos.position);

        if (plDistance <= attackRng)
        {
            direction = (plPos.position - transform.position).normalized;
            transform.Translate(direction * Time.deltaTime * enSpeed);
        }
    }
}
