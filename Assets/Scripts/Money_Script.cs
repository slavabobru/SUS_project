using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_Script : MonoBehaviour
{
    public int rotationSpeed = 70; 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);

    }
    
}
