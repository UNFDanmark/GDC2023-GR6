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
    // [SerializeField] private float Dashtimer;

     [SerializeField] private float Maxdashpoints = 30;
     //variabel for hvad dashtimeren max tæler op til
     [SerializeField] private float dashCounter;

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
        // DashInput = Input.GetKey("K");
   
        
        // implement a way to stop player from using dash when idle
         if (Input.GetKeyDown(KeyCode.Space) && dashCounter >= DashCooldown )
         {
             DashSpeed = DashspeedSerialized;
             dashCounter -= DashCooldown;
print("cum");
         }
         else
         {
             DashSpeed = 1;
         }

         Vector3 direction = (Vector3.forward * MoveInput + Vector3.right * sidewaysInput).normalized;

         Vector3 moveVector = direction * (DashSpeed * PlayerSpeed * Time.deltaTime);
         moveVector.y = body.velocity.y;
         body.velocity = moveVector;
         

      

         //Dashtimer tæler op til 30
         if (dashCounter < Maxdashpoints)
         {
             dashCounter += Time.deltaTime;
         }



         modelTransform.LookAt(direction + modelTransform.position, Vector3.up);
     }
 }