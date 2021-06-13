using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeedJump : MonoBehaviour,IBonus
{
    Constants constants = new Constants();
    private PlayerMove _player;

    private void Awake()
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

}
