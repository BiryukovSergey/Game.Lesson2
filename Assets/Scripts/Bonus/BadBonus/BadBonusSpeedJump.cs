using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBonusSpeedJump : MonoBehaviour,IBadBonus
{
    Constants constants = new Constants();
    internal PlayerMove _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMove>();
    }
    public void BadBonus()
    {
        if(_player.Speed > constants.MinSpeed && _player.JumpForce > constants.MinJump)
        {
            _player.Speed -= constants.BadBonusSpeed;
            _player.JumpForce -= constants.BadBonusJump;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(constants.TagPlayer))
        StartCoroutine(inEnterBad());
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(constants.TagPlayer))
        StartCoroutine(inExitBad());
    }

    public IEnumerator inEnterBad()
    {
        yield return null;
        if(_player.Speed > constants.MinSpeed && _player.JumpForce > constants.MinJump)
        {
            _player.Speed -= constants.BadBonusSpeed;
            _player.JumpForce -= constants.BadBonusJump;
            Debug.Log("Ваша скорость и высота прыжка временно уменьшины!");
        }
    }
    public IEnumerator inExitBad()
    {
        yield return new WaitForSeconds(constants.TimeColldawn);
        if(_player.Speed > constants.MinSpeed && _player.JumpForce > constants.MinJump)
        {
            _player.Speed += constants.BadBonusSpeed;
            _player.JumpForce += constants.BadBonusJump;
            Debug.Log("Отрицательный бонус деактивирован!");
        }
    }
}
