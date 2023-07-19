using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WizardFoodUIScript : MonoBehaviour
{


    public Foodspawnerscript FoodSpawner;
    public TMP_Text counter;
    public TMP_Text counter2;
    public PlayerMovement PlayerInfo;
        
    // Start is called before the first frame update
    void Start()
    {
        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
    counter.text = ":"+PlayerInfo.Player1Food;
    counter2.text = PlayerInfo.Player2Food + ":";
    print(PlayerInfo.Player2Food);


    }
}
