using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour 
{

    
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if(collision.gameObject.tag == "Player") {
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }

        //Zmniejsza HP
        if (collision.gameObject.tag == "Niszczyciel")
        {
            Destroy(gameObject);
            GameManager.instance.DecreaseLifes();
        }

    }


}
