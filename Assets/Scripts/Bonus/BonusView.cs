using System;
using UnityEngine;
using Object = System.Object;

namespace Bonus
{
    public class BonusView : MonoBehaviour
    {
        [SerializeField]
        private Transform[] _badBonusPosition;

        internal BonusController _bonusController;
        [SerializeField]
        internal BonusSO So;
        internal BonusBad Bad;

        private void Awake()
        {
            //So = new BonusSO();
            Bad = new BonusBad(So);
            if (Bad is IBonuses bonus)
            {
                for (int i = 0; i < _badBonusPosition.Length; ++i)
                {
                    Bad.Create<BonusBad>(So, _badBonusPosition[i].transform);
                    Debug.Log(Bad.ToString());
                }
                
            }
        }
    }
}