namespace Bonus
{
    public class BonusBad : IBonuses
    {
        protected float JumpForce;
        protected float Speed;
        
        public BonusBad(BonusSO bonus)
        {
            JumpForce = bonus.jumpForce;
            Speed = bonus.speed;
        }
    }
}