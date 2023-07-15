using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Foodspawnerskript : MonoBehaviour
{

    public GameObject Food;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float Ypos;
     private float FoodSpawnTimer = 0f;
     private float AmountOfFood;
    [SerializeField] private float MaxAmountFood;
    [SerializeField] private float FoodSpawnRate;
    
    
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

            Instantiate(Food, new Vector3(Xpos, Ypos, Zpos), Quaternion.identity);

            AmountOfFood++;
            print(FoodSpawnTimer);
            FoodSpawnTimer = 0;


        } 
        

        FoodSpawnTimer = FoodSpawnTimer + Time.deltaTime;

      





    }
}
