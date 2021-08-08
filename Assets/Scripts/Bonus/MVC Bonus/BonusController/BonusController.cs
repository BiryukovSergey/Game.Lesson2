using System.Collections.Generic;
using UnityEngine;

namespace Bonus
{
    public class BonusController : IBonuses
    {
        public static Object CreateBadBonus<T>(Transform pos)
        {
            var gameObject = Resources.Load("BadBonus");
            var spawnGameobject = Object.Instantiate(gameObject, pos.position, Quaternion.identity);
            return spawnGameobject;
        } 
        public static Object CreateGoodBonus<T>(Transform pos)
        {
            var gameObject = Resources.Load("GoodBonus");
            var spawnGameobject = Object.Instantiate(gameObject, pos.position, Quaternion.identity);
            return spawnGameobject;
        } 
    }
}