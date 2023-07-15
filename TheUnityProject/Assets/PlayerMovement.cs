using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;





public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody body;
    [SerializeField] private float PlayerSpeed = 10;
    [SerializeField] Transform modelTransform;


    private float MoveInput;
    private float sidewaysInput;
        

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveInput = Input.GetAxis("Vertical");
        sidewaysInput = Input.GetAxis("Horizontal");
        
        Vector3 direction = (Vector3.forward *  MoveInput + Vector3.right * sidewaysInput).normalized;

        Vector3 moveVector = direction * (PlayerSpeed * Time.deltaTime);
        moveVector.y = body.velocity.y;
        body.velocity = moveVector;

        modelTransform.LookAt(direction + modelTransform.position, Vector3.up);
    }


    private void FixedUpdate()
    {
       
    }



}
