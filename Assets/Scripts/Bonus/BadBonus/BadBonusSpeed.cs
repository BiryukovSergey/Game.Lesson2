using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBonusSpeed : MonoBehaviour, IBadBonus
{
    Constants constants = new Constants();
    private PlayerMove _player;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMove>();
    }
    public void BadBonus()
    {
        if (_player.Speed > constants.MinSpeed)
            _player.Speed -= constants.BadBonusSpeed;
    }
}
