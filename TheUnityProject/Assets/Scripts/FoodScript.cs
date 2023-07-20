using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    
    public Foodspawnerscript FoodSpawner;
    public GameObject Player1Info;
    public GameObject Player2Info;
    public AudioSource AudioPickup1;
    public AudioSource AudioPickup2;
    public AudioSource AudioPickup3;
    public float PickupVolume;

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
               other.GetComponentInParent<PlayerCombatScript>().PlayerHP++;
            } 
            
            if (other.GetComponentInParent<PlayerMovement>().playerNumber == 2)
            {
                other.GetComponentInParent<PlayerMovement>().Player2Food++;
                other.GetComponentInParent<PlayerCombatScript>().PlayerHP++;
            }
            

            FoodSpawner.AmountOfFood--;
            switch (Random.Range(0, 3)) {
                case 0:
                    AudioPickup1.PlayOneShot(AudioPickup1.clip, PickupVolume);
                    break;
                case 1:
                    AudioPickup2.PlayOneShot(AudioPickup2.clip, PickupVolume);
                    break;
                case 2:
                    AudioPickup3.PlayOneShot(AudioPickup3.clip, PickupVolume);
                    break;
            }
           
            Destroy(gameObject);
             
            
            
        }
    }
}
