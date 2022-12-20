using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMove : MonoBehaviour
{
    [SerializeField] float trainspeed = 1;
    GameManager manager;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0) * trainspeed * Time.deltaTime;
        rb.AddForce(Vector3.right * trainspeed * Time.deltaTime);
    }

    
    
}
