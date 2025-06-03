using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public float speed = 5f;  
    void Update()
    {
        float move = Input.GetAxis("Horizontal");      //arrowkeys ka input
        transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;
    }
}

