using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;


public class PlayerHealthBarScript : MonoBehaviour
{


    public GameObject PlayerInfo;
    public Slider SliderInfo;
    private PlayerCombatScript playerScript;
    


    private void Start()
    {
        playerScript = PlayerInfo.GetComponent<PlayerCombatScript>();
    }

    private void Update()
    {
        SliderInfo.maxValue = playerScript.PlayerMaxHP;
       
        SliderInfo.value = playerScript.PlayerHP;

    }
}

