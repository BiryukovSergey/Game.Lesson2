using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Bonus
{
    public class BonusController : IBonuses
    {
        internal List<BonusBad> _bonusBads;
        internal List<BonusGood> _bonusGoods;
       
        public BonusGood this [int index]
        {
            get { return _bonusGoods[index]; }
            set { _bonusGoods[index] = value; }
        }
        
        public BonusController()
        {
            _bonusBads = new List<BonusBad>();
            _bonusGoods = new List<BonusGood>();
        }
    }
}