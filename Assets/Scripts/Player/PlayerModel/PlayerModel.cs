namespace Player.PlayerModel
{
    internal class PlayerModel
    {
        internal delegate void Moving();
        internal event Moving moving;

        internal bool _ground;
        internal float _resetTime = 5.0f;
        internal bool _isResetTime = true;
    
        internal float JumpForce;
        internal float Speed;

        public PlayerModel()
        {
          _ground = true;
          _resetTime = 5.0f;
          _isResetTime = true;
          JumpForce = 130;
          Speed = 5;
            
        }
        
    }
}