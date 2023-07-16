using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    
    public Foodspawnerscript FoodSpawner;
    
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

            FoodSpawner.AmountOfFood--;
            
           
            Destroy(gameObject);
             
            
            
        }
    }
}
