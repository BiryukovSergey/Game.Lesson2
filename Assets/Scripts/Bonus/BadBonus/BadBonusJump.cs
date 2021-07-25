
using Controller;
using UnityEngine;

public class BadBonusJump : IBadBonus
{
    internal PlayerMove _player;

    public void BadBonus()
    {
        if (_player.JumpForce > Constants.MinJump)
           _player.JumpForce -= Constants.BadBonusJump;
    }

   
}
