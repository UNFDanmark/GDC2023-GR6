using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    
    public Foodspawnerscript FoodSpawner;
    public GameObject Player1Info;
    public GameObject Player2Info;
    
    private PlayerMovement PlayerScript1;
    private PlayerMovement PlayerScript2;
    
    // Start is called before the first frame update
    void Start()
    {


       
        
             
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            print(other.transform.name);
            if (other.GetComponentInParent<PlayerMovement>().playerNumber == 1)
            {
               
               other.GetComponentInParent<PlayerMovement>().Player1Food++;
            } 
            
            if (other.GetComponentInParent<PlayerMovement>().playerNumber == 2)
            {
                other.GetComponentInParent<PlayerMovement>().Player2Food++;
            }
            

            FoodSpawner.AmountOfFood--;
            
           
            Destroy(gameObject);
             
            
            
        }
    }
}
