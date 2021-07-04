namespace DefaultNamespace.Player.PlayerView
{
    public class PlayerView
    {
        public delegate void PlayerMoving();
        public PlayerMoving playerMoving;
        
        // internal event PlayerMoving moving = () => {};
    }
}