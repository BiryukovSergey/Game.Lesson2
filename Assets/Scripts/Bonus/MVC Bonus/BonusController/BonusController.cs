using System.Collections.Generic;
using UnityEngine;

namespace Bonus
{
    public class BonusController : IBonuses
    {
        internal List<BonusBad> _bonusBads;
        internal List<BonusGood> _bonusGoods;

        
        public BonusController()
        {
            _bonusBads = new List<BonusBad>();
            _bonusGoods = new List<BonusGood>();
        }
        
        public static Object CreateBadBonus<T>(Transform pos)
        {
            var gameObject = Resources.Load("BadBonus");
            var b = Object.Instantiate(gameObject, pos.position, Quaternion.identity);
            return b;
        } 
        public static Object CreateGoodBonus<T>(Transform pos)
        {
            var gameObject = Resources.Load("GoodBonus");
            var b = Object.Instantiate(gameObject, pos.position, Quaternion.identity);
            return b;
        } 
    }
}