using System;
using UnityEngine;

namespace Bonus
{
    public class BonusGood : IBonuses
    {
        protected float JumpForce;
        protected float Speed;
        private BonusModel _bonusModel; 

        public BonusGood(BonusSO bonus)
        {
            _bonusModel.JumpForce = bonus.JumpForce;
            _bonusModel.Speed = bonus.Speed;
        }
    }
}