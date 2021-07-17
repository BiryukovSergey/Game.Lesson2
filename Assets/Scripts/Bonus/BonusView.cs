using System;
using UnityEngine;
using Object = System.Object;

namespace Bonus
{
    public class BonusView : MonoBehaviour
    {
        [SerializeField]
        private Transform[] _goodBonusPosition;
        [SerializeField]
        private Transform[] _badBonusPosition;

        private BonusController _bonusController;
        private void Awake()
        {
            _bonusController = new BonusController();
           for (int i = 0; i < _badBonusPosition.Length; i++)
            {
                if (_badBonusPosition[i] != null)
                {
                    //_badBonusPosition[i].position = вот здесь не могу понять в чем проблема я не могу написать ;
                    //_badBonusPosition[i] = _bonusController._bonusBads[i].transform;
                }
            }
        }
    }
}