using System;
using UnityEngine;
using Object = System.Object;

namespace Bonus
{
    public class BonusView : MonoBehaviour
    {
        [SerializeField] internal Transform[] badBonusPosition;
        [SerializeField] internal Transform[] goodBonusPosition;
        [SerializeField] internal BonusSO so;
        
        internal BonusController bonusController;
        internal BonusBad bad;
        internal BonusGood bonusGood;

        private void Awake()
        {
            bad = new BonusBad(so);
            bonusGood = new BonusGood(so);
            
            if (bad is IBonuses bonus)
            {
                for (int i = 0; i < badBonusPosition.Length; ++i)
                {
                    BonusController.CreateBadBonus<BonusBad>(badBonusPosition[i]);
                }
            }

            if (bonusGood is IBonuses bonuses)
            {
                for (int i = 0; i < goodBonusPosition.Length; i++)
                {
                    BonusController.CreateGoodBonus<BonusGood>(goodBonusPosition[i]);
                }
            }
        }
    }
}