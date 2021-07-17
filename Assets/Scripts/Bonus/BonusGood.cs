using System;
using UnityEngine;

namespace Bonus
{
    public class BonusGood : IBonuses
    {
        protected float JumpForce;
        protected float Speed;

        public BonusGood(BonusSO bonus)
        {
            JumpForce = bonus.jumpForce;
            Speed = bonus.speed;
        }
    }
}