using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    int randomizer;
    SpriteRenderer sprite;
    List<Color> colorchoose;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

       
        colorchoose = new List<Color>();
        colorchoose.Add(Color.red);
        colorchoose.Add(Color.blue);
        colorchoose.Add(Color.green);
        randomizer = Random.Range(0, 3);
        sprite.color = colorchoose[randomizer];

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            if (randomizer == 1)
            {

            }
        }
    }
}
