using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class MoveSanta : MonoBehaviour
{
    Rigidbody2D rb;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI scoreText;
    int highscore = 0;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        // if(PlayerPrefs.GetInt("HighScore") != Null){
        //     highscore = PlayerPrefs.GetInt("HighScore");
        // } else{
        //     highscore = 0;
        // }
        highscore = PlayerPrefs.GetInt("HighScore");

        highscoreText.text = highscoreText.text+": "+highscore;
        scoreText.text = scoreText.text+": "+score;

    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown("Fire1")){

        // }
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
        score += (int)Math.Ceiling(Time.deltaTime);
        scoreText.text = "Score: "+score;
        PlayerPrefs.SetInt("Score",score);
    }
}
