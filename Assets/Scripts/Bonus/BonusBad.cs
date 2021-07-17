using UnityEngine;

namespace Bonus
{
    public class BonusBad : IBonuses
    {
        private BonusModel _bonusModel;
        public BonusBad(BonusSO bonus)
        {
            _bonusModel = new BonusModel();
            _bonusModel.JumpForce = bonus.JumpForce;
            _bonusModel.Speed = bonus.Speed;
        }

        internal Object Create<T>(BonusSO bonus, Transform pos)
        {
            BonusBad bad = new BonusBad(bonus);
            var a = Resources.Load("Cube");
            var b = Object.Instantiate(a, pos.position,Quaternion.identity);
            return b;
        } 
    }
}