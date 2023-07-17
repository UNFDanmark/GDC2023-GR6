using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayerCombatScript : MonoBehaviour
{
    [SerializeField] private float BiteAttackTimer = 5;
    [SerializeField] private float BiteAttackCooldown = 5;
    [SerializeField] private float BufferTimer;
    [SerializeField] private float BufferCooldown = 5;
    [SerializeField] private float PlayerHP = 100;
    [SerializeField] private float BiteAttackDamage = 10;
    public PlayerMovement MainPlayerScript;
    
    public GameObject BiteAttackArea1;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
     
        
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {


        
         
            
    }
        // this happens when player gets hit
   
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("BiteAttackArea"))

            {
                PlayerHP -= BiteAttackDamage;
                print("cum");

           
            
            }
                
        }
    private void FixedUpdate()
    {
        if (MainPlayerScript.playerNumber == 1)
        {
            if (Input.GetButtonDown("BiteAttackPlayer1") && BiteAttackTimer <= 0)
            {
                print("Player 1 attacked!");
                BiteAttackTimer = BiteAttackCooldown;
                BiteAttackArea1.SetActive(true);
                BufferTimer = BufferCooldown;

            }
        }

        if (MainPlayerScript.playerNumber == 2)
        {
            if (Input.GetKeyDown(KeyCode.K) && BiteAttackTimer <= 0)
            {
                print("Player 2 attacked!");
                BiteAttackTimer = BiteAttackCooldown;
                BiteAttackArea1.SetActive(true);
                BufferTimer = BufferCooldown;

            }
        }

        if (BufferTimer <=0)
        {
            BiteAttackArea1.SetActive(false);
            
        }

        BufferTimer -= Time.deltaTime;
        BiteAttackTimer -= Time.deltaTime;


    }
    
    
    
    
    
}




    

   



    
    

