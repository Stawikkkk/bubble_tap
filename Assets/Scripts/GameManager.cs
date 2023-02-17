using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public GameObject livesholder;


    int score = 0;
    int lifes = 3;
    

    

    bool gameOver = false;

   
    public TextMeshProUGUI scoreText;

    


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            Debug.Log(score);
        }

    }

    public void DecreaseLifes()
    {
        if (lifes > 0)
        {
            lifes--;
            livesholder.transform.GetChild(lifes).gameObject.SetActive(false);
            
            
            Debug.Log(lifes);
        }
        else if (lifes <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        CandySpawner.instance.StopSpawnigCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        Debug.Log("GameOver");
    }
}
