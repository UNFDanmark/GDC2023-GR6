 using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;





 public class PlayerMovement : MonoBehaviour
 {
     [SerializeField] private Rigidbody body;
     [SerializeField] private float PlayerSpeed = 10;
     [SerializeField ]private float DashSpeed = 1;
     [SerializeField] Transform modelTransform;
     [SerializeField] private float DashspeedSerialized = 5;
     [SerializeField] private float DashCooldown = 10;
     [SerializeField] private float Dashtimer;

     [SerializeField] private float Maxdashpoints = 30;
     //variabel for hvad dashtimeren max tæler op til

     private float MoveInput;
     private float sidewaysInput;
     private bool DashInput;



     // Start is called before the first frame update
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {
         MoveInput = Input.GetAxis("Vertical");
         sidewaysInput = Input.GetAxis("Horizontal");
         DashInput = Input.GetButtonDown("Jump");
   
         

         Vector3 direction = (Vector3.forward * MoveInput + Vector3.right * sidewaysInput).normalized;

         Vector3 moveVector = direction * (DashSpeed * PlayerSpeed * Time.deltaTime);
         moveVector.y = body.velocity.y;
         body.velocity = moveVector;
         print(DashInput);

         if (DashInput && Dashtimer >= DashCooldown)
         {
             DashSpeed = DashspeedSerialized;
             Dashtimer -= DashCooldown;

         }
         else
         {
             DashSpeed = 1;
         }

         //Dashtimer tæler op til 30
         if (Dashtimer < Maxdashpoints) ;
         {
             Dashtimer = Dashtimer + Time.deltaTime;
         }



         modelTransform.LookAt(direction + modelTransform.position, Vector3.up);
     }
 }