/*
using UnityEngine;

public class BonusSpeed : MonoBehaviour, IBonus
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
            _player.Speed += constants.GoodBonusSpeed;
    }
}*/
