using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public bool jump = true;
    public Rigidbody2D rb2d;
    [SerializeField] float playerSpeed = 7.5f;
    [SerializeField] float slideSpeed = 10f;
    [SerializeField] float jumpForce = 3.5f;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI Extra;
    [SerializeField] float point = 0;
    float pointValue = 1;
    
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space) && jump == true)
        {
            rb2d.AddForce(Vector3.up * jumpForce);
            jump = false;
        }
        
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            
            rb2d.AddForce(Vector3.right * slideSpeed * playerSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, 60);
            
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {

            rb2d.AddForce(Vector3.left * slideSpeed * playerSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 0, -60);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.eulerAngles = new Vector3 (0, 0, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Train" || collision.gameObject.tag == "Hinder")
        {
            Destroy(gameObject);
            Extra.text = "Game Over";
        }
        else
        {
            jump = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        if (collision.gameObject.tag == "Coin")
        {
            point += pointValue;
            score.text = "Point: " + point;
        }
        else if (collision.gameObject.tag == "jumpPower")
        {
            jumpForce *= 1.25f;
        }
        else if (collision.gameObject.tag == "speedPower")
        {
            playerSpeed *= 1.25f;
        }
        else if (collision.gameObject.tag == "pointPower")
        {
            pointValue *= 2;
        }
        else if (collision.gameObject.tag == "Finish")
        {
            Extra.text = "wow du vann";
        }
    }

}
        


