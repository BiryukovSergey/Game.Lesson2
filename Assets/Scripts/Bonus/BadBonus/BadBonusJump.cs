
using Controller;
using UnityEngine;

public class BadBonusJump : InteractiveObject, IBadBonus
{
    Constants constants = new Constants();
    internal PlayerMove _player;

    private void Awake()
    {
       // _player = FindObjectOfType<PlayerMove>();
    }
    public void BadBonus()
    {
        if (_player.JumpForce > constants.MinJump)
           _player.JumpForce -= constants.BadBonusJump;
    }

   
}
