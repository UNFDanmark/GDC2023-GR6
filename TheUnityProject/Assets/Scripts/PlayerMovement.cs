 using System;
 using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
 using UnityEngine.PlayerLoop;


 public class PlayerMovement : MonoBehaviour
 {
     [SerializeField] private Rigidbody body;
     [SerializeField] private float PlayerSpeed = 10;
     [SerializeField ]private float DashSpeed = 5;
     [SerializeField] Transform modelTransform;
     [SerializeField] private float DashCooldown = 10;
     [SerializeField] public int playerNumber;
    // [SerializeField] private float Dashtimer;

    public float TimeLeaftBetweenDashes=0;
    public float DashCooldownBetweenDashes=1;

    public AudioSource DashAudio;
    public float DashAudioVolume;

     [SerializeField] private float Maxdashpoints = 30;
     //variabel for hvad dashtimeren max tæler op til
     [SerializeField] public float dashCounter;
     public int Player1Food;
     public int Player2Food;

     private float MoveInput;
     private float sidewaysInput;
     private bool DashInput;
     private Vector3 direction;



     // Start is called before the first frame update
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {
      
         if (playerNumber == 1)
         {
             MoveInput = Input.GetAxis("VerticalPlayer1");
             sidewaysInput = Input.GetAxis("HorizontalPlayer1");
             direction = (Vector3.forward * MoveInput + Vector3.right * sidewaysInput).normalized;
       
/*
             string[] joysticknames = Input.GetJoystickNames();
             foreach (var joystickname in joysticknames)
                 
             {
                 print(joystickname);

             }
             */
         }
         if (playerNumber == 2)
         {
             MoveInput = Input.GetAxis("VerticalPlayer2");
             sidewaysInput = Input.GetAxis("HorizontalPlayer2");
             direction = (Vector3.forward * MoveInput + Vector3.right * sidewaysInput).normalized;
         }
         
      
         
// constantly counting from DashcooldownBetweenDashes which is 1 to negative value
        TimeLeaftBetweenDashes -= Time.deltaTime;
        
        // implement a way to stop player from using dash when idle
        
        //TimeleaftBetweenDashes stops player from dashing more than once a second

        if (playerNumber == 1)
        {
           // print(Input.inputString);
            if (Input.GetButtonDown("DashPlayer1"))
            {
               // print("first");
                if (dashCounter >= DashCooldown && TimeLeaftBetweenDashes <= 0)
                {
                    dashCounter -= DashCooldown;
                    DashAudio.PlayOneShot(DashAudio.clip, DashAudioVolume);
                    print("...");
                    TimeLeaftBetweenDashes = DashCooldownBetweenDashes;
                    Vector3 moveVector = direction * (DashSpeed * PlayerSpeed);
                    body.AddForce(moveVector, ForceMode.Impulse);
                  //  print("second");
                }
            }
           

        }
        if (playerNumber == 2)
        {
            if (Input.GetButtonDown("DashPlayer2"))
            {
                if (dashCounter >= DashCooldown && TimeLeaftBetweenDashes <= 0)
                {
                    
                    dashCounter -= DashCooldown;
                    DashAudio.PlayOneShot(DashAudio.clip, DashAudioVolume);
                    TimeLeaftBetweenDashes = DashCooldownBetweenDashes;
                    Vector3 moveVector = direction * (DashSpeed * PlayerSpeed);
                    body.AddForce(moveVector, ForceMode.Impulse);
                }
             
            }
        

        }
         
        

      

         //Dashtimer tæler op til 30
         if (dashCounter < Maxdashpoints)
         {
             dashCounter += Time.deltaTime;
         }



         modelTransform.LookAt(direction + modelTransform.position, Vector3.up);
     }

     private void FixedUpdate()
     {
         
        

         Vector3 moveVector = direction * (PlayerSpeed);
         moveVector.y = body.velocity.y;
         body.velocity = moveVector;

     }
 }