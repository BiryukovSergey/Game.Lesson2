namespace Player.PlayerModel
{
    internal class PlayerModel
    {
        internal delegate void Moving();
        internal event Moving moving;
        
        internal float jumpForce;
        internal float speed;

        public PlayerModel()
        {
          //_ground = true;
          //_resetTime = 5.0f;
          //_isResetTime = true;
          jumpForce = 130;
          speed = 5;
        }
    }
}