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
    [SerializeField] int point;
    

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
        if (collision.gameObject.tag == "Train")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            point += 1;
            score.text = "Point: " + point;
        }
        else if (collision.gameObject.tag == "Hinder")
        {
            Time.timeScale = 0.5f;
            
        }
        else
        {
            jump = true;
        }
    }

}

