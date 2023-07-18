using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityBarUIScript : MonoBehaviour
{


    public GameObject playerInfo; 
    private PlayerCombatScript playerScript;
    private PlayerMovement movementScript;
    
    private float AlphaValue;
    public Image DashIconCover;
    public Image BiteIconCover;
    public Image BoneIconCover;
    
    
   
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        playerScript = playerInfo.GetComponent<PlayerCombatScript>();
        movementScript = playerInfo.GetComponent<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        if (movementScript.TimeLeaftBetweenDashes <= 0)
        {
            Color color = DashIconCover.color;
            
            color.a = 0;

            DashIconCover.color = color;

        }
        else
        {
            
            
            Color color = DashIconCover.color;
            
            color.a = 0.7f;

            DashIconCover.color = color;

            //makes this go fully transparent
        }



        if (playerScript.BiteAttackTimer <= 0)
        {
            Color color = BiteIconCover.color;
            
            color.a = 0;

            BiteIconCover.color = color;

        }
        else
        {
            
            
            Color color = BiteIconCover.color;
            
            color.a = 0.7f;

            BiteIconCover.color = color;

            //makes this go fully transparent
        }
        if (playerScript.SwordAttackTimer <= 0 && playerScript.SwordPurchased == true)
        {
            Color color = BoneIconCover.color;
            
            color.a = 0;

            BoneIconCover.color = color;

        }
        
        // makes this go semi transparent
        else
        {
            
            
            Color color = BoneIconCover.color;
            
            color.a = 0.7f;

            BoneIconCover.color = color;

            
        }
        
        
        
        
    }
}
