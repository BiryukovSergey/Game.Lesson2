using System;
using UnityEngine;

namespace Bonus
{
    public class BonusGood : IBonuses
    {
        internal float jumpForce;
        internal float speed;
        internal BonusSO So;
       
        public BonusGood(BonusSO bonus)
        {
            jumpForce = bonus.JumpForce;
            speed = bonus.Speed;
        }
    }
}