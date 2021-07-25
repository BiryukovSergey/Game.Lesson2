using System;
using System.Collections;
using UnityEngine;

public class BadBonusSpeedJump : MonoBehaviour,IBadBonus
{ 
   
    internal event Action badBonusDelegat = () => {};
        
   internal PlayerMove _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMove>();
    }
    public void BadBonus()
    {
        if(_player.Speed > Constants.MinSpeed && _player.JumpForce > Constants.MinJump)
        {
            _player.Speed -= Constants.BadBonusSpeed;
            _player.JumpForce -= Constants.BadBonusJump;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Constants.TagPlayer))
        StartCoroutine(inEnterBad());
        badBonusDelegat.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(Constants.TagPlayer))
        StartCoroutine(inExitBad());
    }

    public IEnumerator inEnterBad()
    {
        yield return null;
        if(_player.Speed > Constants.MinSpeed && _player.JumpForce > Constants.MinJump)
        {
            badBonusDelegat += BadBonus;
           // badBonusDelegat.Invoke();
            Debug.Log("Ваша скорость и высота прыжка временно уменьшины!");
        }
    }
    public IEnumerator inExitBad()
    {
        yield return new WaitForSeconds(Constants.TimeColldawn);
        if(_player.Speed > Constants.MinSpeed && _player.JumpForce > Constants.MinJump)
        {
            badBonusDelegat -= BadBonus;
            Debug.Log("Отрицательный бонус деактивирован!");
        }
    }

    ~BadBonusSpeedJump()
    {
        badBonusDelegat -= BadBonus;
    }
}




