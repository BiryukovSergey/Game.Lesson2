namespace DefaultNamespace.Player.PlayerView
{
    public class PlayerView
    {
        internal delegate void PlayerMoving();
        internal event PlayerMoving moving = () => {};
    }
}