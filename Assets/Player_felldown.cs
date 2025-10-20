using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_felldown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
 
    
    
    }

   

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
            {
                GameManager.Instance.PlayerDied();
                GameManager.Instance.ResumeGame();
                
            }
        }
    }










}
