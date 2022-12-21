using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMove : MonoBehaviour
{
    void Update()
    {
        transform.position = transform.position + new Vector3(-3,0,0) * Time.deltaTime;
    }
}
