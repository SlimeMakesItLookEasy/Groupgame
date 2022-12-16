using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float playerSpeed = 7.5f;
    [SerializeField] float slideSpeed = 10f;
    float jumpForce = 3.5f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= Vector3.right * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * jumpForce * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            
            transform.position += Vector3.right * slideSpeed * playerSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 0, 60);
            
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {

            transform.position -= Vector3.right * slideSpeed * playerSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 0, -60);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.eulerAngles = new Vector3 (0, 0, 0);
        }
    }
}
