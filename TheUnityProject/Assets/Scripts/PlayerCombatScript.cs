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

    [SerializeField] private float BiteBufferTimer;
    [SerializeField] private float BiteBufferCooldown = 5;
    
    
    [SerializeField] private float SwordAttackTimer = 5;
    [SerializeField] private float SwordAttackCooldown = 5;
        
    [SerializeField] private float SwordBufferTimer;
    [SerializeField] private float SwordBufferCooldown;

    [SerializeField] private float SwordAttackDamage = 10;
    
        
        
    
    
    [SerializeField] private float PlayerHP = 100;
    [SerializeField] private float BiteAttackDamage = 10;
    [SerializeField] private bool SwordPurchased = true;
    
    
    [SerializeField]
    
    
    public PlayerMovement MainPlayerScript;
    
    public GameObject BiteAttackArea1;
    public GameObject SwordAttackArea1;
    
    
    
    
    
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
                print("Player was hit by bite attack!");

           
            
            } else if (other.CompareTag("SwordAttackArea"))
            {
                PlayerHP -= SwordAttackDamage;
                print("Player was hit by Sword attack!");
                
            }
                
        }
    private void FixedUpdate()
    {
        if (MainPlayerScript.playerNumber == 1)
        {
            if (Input.GetButtonDown("BiteAttackPlayer1") && BiteAttackTimer <= 0 && SwordPurchased == false)
            {
                print("Player 1 bite attacked!");
                BiteAttackTimer = BiteAttackCooldown;
                BiteAttackArea1.SetActive(true);
                BiteBufferTimer = BiteBufferCooldown;

            } else if (Input.GetButtonDown("BiteAttackPlayer1") && SwordAttackTimer <=0 && SwordPurchased == true)
            {
                print("Player 1 sword attacked!");
                SwordAttackTimer = SwordAttackCooldown;
               SwordAttackArea1.SetActive(true);
                SwordBufferTimer = SwordBufferCooldown;
            }
            
           
            

        }
        if (MainPlayerScript.playerNumber == 2)
        {
            //change keybind later
            
            if (Input.GetKey(KeyCode.L) && BiteAttackTimer <= 0 && SwordPurchased == false)
            {
                print("Player 2 bite attacked!");
                BiteAttackTimer = BiteAttackCooldown;
                BiteAttackArea1.SetActive(true);
                BiteBufferTimer = BiteBufferCooldown;

            } else if (SwordAttackTimer <=0 && SwordPurchased == true)
            {
                print("Player 2 sword attacked!");
                SwordAttackTimer = SwordAttackCooldown;
                BiteAttackArea1.SetActive(true);
                SwordBufferTimer = SwordBufferCooldown;
            }
            
           
            

        }
        

        if (BiteBufferTimer <=0)
        {
            BiteAttackArea1.SetActive(false);
            
        }
        
        if (SwordBufferTimer <=0)
        {
            SwordAttackArea1.SetActive(false);
            
        }

        BiteBufferTimer -= Time.deltaTime;
        BiteAttackTimer -= Time.deltaTime;
        SwordBufferTimer -= Time.deltaTime;
        SwordAttackTimer -= Time.deltaTime;

        /*
        if (PlayerHP <= 0) ;
        {

            if (MainPlayerScript.playerNumber == 1)

            {
                Player 1 Wins 
                    Delay
                Scene
            }
            else
            {
                Player 2 Wins 
                    Delay
                Scene  
            }
        }
        */


    }
    
    
    
    
    
}




    

   



    
    

