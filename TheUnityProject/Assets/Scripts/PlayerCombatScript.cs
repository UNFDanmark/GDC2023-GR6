using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayerCombatScript : MonoBehaviour
{
    [SerializeField] public float BiteAttackTimer = 5;
    [SerializeField] private float BiteAttackCooldown = 5;

    [SerializeField] private float BiteBufferTimer;
    [SerializeField] private float BiteBufferCooldown = 5;
    
    
    [SerializeField] public float SwordAttackTimer = 5;
    [SerializeField] private float SwordAttackCooldown = 5;
        
    [SerializeField] private float SwordBufferTimer;
    [SerializeField] private float SwordBufferCooldown;

    [SerializeField] private int SwordAttackDamage = 10;

    private float HeartbeatTimer = 0;
    public float HeartbeatCooldown;
    public float HeartBeatVolume;
    public AudioSource Bite1;
    public AudioSource Bite2;
    public AudioSource Bite3;
    public float BiteVolume;

    private bool BiteAttackhappend1;
    private bool BiteAttackhappend2;
    
    
    public int PlayerHP = 1;
    public int PlayerMaxHP = 1;
    public float DramaticHeartAtProcent;
    public AudioSource Heart;
    [SerializeField] private int BiteAttackDamage = 10;
    [SerializeField] public bool SwordPurchased = true;
    
    
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



       
        
        
        
        BiteAttackhappend1 = Input.GetButtonDown("BiteAttackPlayer1");
        BiteAttackhappend2 = Input.GetKey(KeyCode.Return);
        
        if (MainPlayerScript.playerNumber == 1)
        {

            if (MainPlayerScript.Player1Food >= 30)
            {
                SwordPurchased = true;
            }
            
            if (BiteAttackhappend1 && BiteAttackTimer <= 0 && SwordPurchased == false)
            {
                print("Player 1 bite attacked!");
                switch (UnityEngine.Random.Range(0, 3)) {
                    case 0:
                        Bite1.PlayOneShot(Bite1.clip, BiteVolume);
                        break;
                    case 1:
                        Bite2.PlayOneShot(Bite2.clip, BiteVolume);
                        break;
                    case 2:
                        Bite3.PlayOneShot(Bite3.clip, BiteVolume);
                        break;
                }
                BiteAttackTimer = BiteAttackCooldown;
                BiteAttackArea1.SetActive(true);
                BiteBufferTimer = BiteBufferCooldown;

            } else if (BiteAttackhappend1 && SwordAttackTimer <=0 && SwordPurchased == true)
            {
                print("Player 1 sword attacked!");
                SwordAttackTimer = SwordAttackCooldown;
                SwordAttackArea1.SetActive(true);
                SwordBufferTimer = SwordBufferCooldown;
            }
            
           
            

        }
        if (MainPlayerScript.playerNumber == 2)
        {
            
            
            
            if (MainPlayerScript.Player2Food >= 30)
            {
                SwordPurchased = true;
            }
            
            if (BiteAttackhappend2 && BiteAttackTimer <= 0 && SwordPurchased == false)
            {
                print("Player 2 bite attacked!");
                switch (UnityEngine.Random.Range(0, 3)) {
                    case 0:
                        Bite1.PlayOneShot(Bite1.clip, BiteVolume);
                        break;
                    case 1:
                        Bite2.PlayOneShot(Bite2.clip, BiteVolume);
                        break;
                    case 2:
                        Bite3.PlayOneShot(Bite3.clip, BiteVolume);
                        break;
                }
                BiteAttackTimer = BiteAttackCooldown;
                BiteAttackArea1.SetActive(true);
                BiteBufferTimer = BiteBufferCooldown;

            } else if (BiteAttackhappend2 && SwordAttackTimer <=0 && SwordPurchased == true)
            {
                print("Player 2 sword attacked!");
                SwordAttackTimer = SwordAttackCooldown;
                SwordAttackArea1.SetActive(true);
                SwordBufferTimer = SwordBufferCooldown;
            }
            

        }


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

            if (MainPlayerScript.playerNumber == 1 && PlayerHP <= 0)
            {
                print("LNMAIO");
                SceneManager.LoadScene("Wizard Win");
            }

            if (MainPlayerScript.playerNumber == 2 && PlayerHP <= 0)
            {
                SceneManager.LoadScene("Fatass Win");
            }
        }
    private void FixedUpdate()
    {

        if (HeartbeatTimer <=  0 && !Heart.isPlaying && PlayerHP <= PlayerMaxHP * DramaticHeartAtProcent) {
            print("...");
            Heart.PlayOneShot(Heart.clip, HeartBeatVolume);
            HeartbeatTimer = HeartbeatCooldown;
        }

        if (BiteBufferTimer <=0)
        {
            BiteAttackArea1.SetActive(false);
            
        }
        
        if (SwordBufferTimer <=0)
        {
            SwordAttackArea1.SetActive(false);
            
        }

        HeartbeatTimer -= Time.deltaTime;
        BiteBufferTimer -= Time.deltaTime;
        BiteAttackTimer -= Time.deltaTime;
        SwordBufferTimer -= Time.deltaTime;
        SwordAttackTimer -= Time.deltaTime;
        
        
        
        


    }
    
    
    
    
    
}




    

   



    
    

