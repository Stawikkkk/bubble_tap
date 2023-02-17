using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int playerScore;

    public bool canMove = true;

   

    [SerializeField]
    float maxPosition;

    [SerializeField]
    float moveSpeed;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }

    private void Move()
    {
       float InputX = Input.GetAxis("Horizontal");

        transform.position += InputX * Vector3.right * moveSpeed * Time.deltaTime;

        float maxPosX = Mathf.Clamp(transform.position.x, -maxPosition, maxPosition);

        transform.position = new Vector3(maxPosX, -3.1f, 0);
    }
}
