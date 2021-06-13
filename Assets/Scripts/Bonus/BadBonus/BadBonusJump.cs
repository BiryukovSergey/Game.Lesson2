using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBonusJump : MonoBehaviour, IBadBonus
{
    Constants constants = new Constants();
    private PlayerMove _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMove>();
    }
    public void BadBonus()
    {
        if (_player.JumpForce > constants.MinJump)
           _player.JumpForce -= constants.BadBonusJump;
        
    }
}
