﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeedJump : MonoBehaviour, IBonus
{
    Constants constants = new Constants();
    internal PlayerMove _player;
    private float t = 5.0f;
    private bool isWorker;
    

    internal void Awake()
    {
        _player = FindObjectOfType<PlayerMove>();
    }
    public void Bonus()
    {
        if (_player.Speed < constants.MaxSpeed && _player.JumpForce < constants.MaxJump)
        {
            _player.Speed += constants.GoodBonusSpeed;
            _player.JumpForce += constants.GoodBonusJump;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(inEnter()); 
        
        /* if (other.GetComponent<IBonus>() != null)
       {
           
       }*/
        
       /* if(other.GetComponent<IBadBonus>() != null)
        {
            other.GetComponent<IBadBonus>().BadBonus();
            //StartCoroutine(im());                    <---------- мусор
        }*/
    }

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(inExit());
    }


    /// <summary>
    /// Пробую через корутину
    /// </summary>
    /// <returns></returns>
    public IEnumerator inEnter()
    {
        yield return null;
        if (_player.Speed < constants.MaxSpeed && _player.JumpForce < constants.MaxJump)
         {
           _player.Speed += constants.GoodBonusSpeed;
           _player.JumpForce += constants.GoodBonusJump;
           Debug.Log("Ваша скорости и высота прыжка временно увеличенны!");
         }
    }
    public IEnumerator inExit()
    {
        yield return new WaitForSeconds(constants.TimeColldawn);
        if (_player.Speed < constants.MaxSpeed && _player.JumpForce < constants.MaxJump)
        {
            _player.Speed -= constants.GoodBonusSpeed;
            _player.JumpForce -= constants.GoodBonusJump;
            Debug.Log("Положительный бонус деактивирован!");
        }
    }
}

    

