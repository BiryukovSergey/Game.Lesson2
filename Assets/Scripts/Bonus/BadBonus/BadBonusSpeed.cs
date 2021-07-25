using Controller;

public class BadBonusSpeed : IBadBonus
{
    internal PlayerMove _player;

    public void BadBonus()
    {
        if (_player.Speed > Constants.MinSpeed)
            _player.Speed -= Constants.BadBonusSpeed;
    }
}
