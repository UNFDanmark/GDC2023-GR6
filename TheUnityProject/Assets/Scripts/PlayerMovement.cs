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
     [SerializeField ]private float DashSpeed = 1;
     [SerializeField] Transform modelTransform;
     [SerializeField] private float DashspeedSerialized = 5;
     [SerializeField] private float DashCooldown = 10;
     [SerializeField] public int playerNumber;
    // [SerializeField] private float Dashtimer;

    private float TimeLeaftBetweenDashes=0;
    private float DashCooldownBetweenDashes=1;

     [SerializeField] private float Maxdashpoints = 30;
     //variabel for hvad dashtimeren max tæler op til
     [SerializeField] private float dashCounter;

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
            if (Input.GetButtonDown("DashPlayer1") && dashCounter >= DashCooldown && TimeLeaftBetweenDashes <= 0)
            {
                DashSpeed = DashspeedSerialized;
                dashCounter -= DashCooldown;

                TimeLeaftBetweenDashes = DashCooldownBetweenDashes;

            }
            else
            {
                DashSpeed = 1;
            }

        }
        if (playerNumber == 2)
        {
            if (Input.GetButtonDown("DashPlayer2") && dashCounter >= DashCooldown && TimeLeaftBetweenDashes <= 0)
            {
                DashSpeed = DashspeedSerialized;
                dashCounter -= DashCooldown;

                TimeLeaftBetweenDashes = DashCooldownBetweenDashes;

            }
            else
            {
                DashSpeed = 1;
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
         
        

         Vector3 moveVector = direction * (DashSpeed * PlayerSpeed);
         moveVector.y = body.velocity.y;
         body.velocity = moveVector;

     }
 }