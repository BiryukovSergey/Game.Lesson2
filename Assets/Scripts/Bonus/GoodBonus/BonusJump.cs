/*
using UnityEngine;

public class BonusJump : MonoBehaviour, IBonus
{
    Constants constants = new Constants();
    internal PlayerMove _player;

    private void Awake()
    {
      _player = FindObjectOfType<PlayerMove>();
    }
    public void Bonus()
    {
        if (_player.JumpForce > constants.MaxJump)
            _player.JumpForce += constants.GoodBonusJump;
    }
}*/
