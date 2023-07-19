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
    public AudioSource AudioPickup1;
    public AudioSource AudioPickup2;
    public AudioSource AudioPikcup3;
    public float PickupVolume;
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
            foodScript.AudioPickup1 = AudioPickup1;
            foodScript.AudioPickup2 = AudioPickup2;
            foodScript.AudioPickup3 = AudioPikcup3;
            foodScript.PickupVolume = PickupVolume;
           AmountOfFood++;
          
            FoodSpawnTimer = 0;


        } 
        

        FoodSpawnTimer = FoodSpawnTimer + Time.deltaTime;

      





    }
}
