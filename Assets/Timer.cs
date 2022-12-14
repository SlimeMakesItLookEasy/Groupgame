using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float threshold;

    float initialTime;

    void Start()
    {
        initialTime = Time.time;
        if(PlayerPrefs.HasKey("HighScoreTime") == false)
        {
            PlayerPrefs.SetFloat("HighScoreTime", 0);
        }

    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            float TimeTaken = Time.time - initialTime;
            if((TimeTaken)>PlayerPrefs.GetFloat("HighScoreTime"))
            {
                print("HighScore time is " + TimeTaken);
                PlayerPrefs.SetFloat("HighScoreTime", TimeTaken);
            }
            transform.position = new Vector3(0, 0, 0);
            initialTime = Time.time;
        }

    }
}
