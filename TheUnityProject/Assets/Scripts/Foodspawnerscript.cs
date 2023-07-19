using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Foodspawnerscript : MonoBehaviour
{

    public GameObject Food;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float Ypos;
    [SerializeField] private float Yrot;
    [SerializeField] private float Yrotmax;
    [SerializeField] private float Yrotmin;
     private float FoodSpawnTimer = 0f;
     public float AmountOfFood;
    [SerializeField] private float MaxAmountFood;
    [SerializeField] private float FoodSpawnRate;
    public GameObject foodItem;
    
    
    // Start is called before the first frame update
    void Start()
    {
          
        
        
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (AmountOfFood < MaxAmountFood && FoodSpawnTimer >= FoodSpawnRate)
        {
            
            float Xpos = Random.Range(minX, maxX);
            float Zpos = Random.Range(minZ, maxZ);
            

           GameObject foodItem = Instantiate(Food, new Vector3(Xpos, Ypos, Zpos), Quaternion.identity);
           FoodScript foodScript = foodItem.GetComponent<FoodScript>();
           foodScript.FoodSpawner = this;
           AmountOfFood++;
          
            FoodSpawnTimer = 0;


        } 
        

        FoodSpawnTimer = FoodSpawnTimer + Time.deltaTime;

      





    }
}
