using UnityEngine;

namespace Bonus
{
    public class BonusBad : IBonuses
    {
        internal float jumpForce;
        internal float speed;
        internal BonusSO bonusSo;
        
        public BonusBad(BonusSO bonus)
        {
            jumpForce = bonus.JumpForce;
            speed = bonus.Speed;
        }

        
    }
}