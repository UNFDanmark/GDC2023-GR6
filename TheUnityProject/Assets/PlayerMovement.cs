using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;





public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody body;
    [SerializeField] private float PlayerSpeed = 10;


    private float MoveInput;
        

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveInput = Input.GetAxis("Vertical");
    }


    private void FixedUpdate()
    {
        //Vector3
        {
            
        }
        
        
    }



}
