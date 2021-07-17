using System.IO;
using UnityEngine;

namespace Bonus
{
    [CreateAssetMenu (menuName = "Bonus/bonus/bonus",fileName = "BonusSO")]
    public class BonusSO : ScriptableObject
    {
        //TODO разобраться и настроить путь для SO
        
        [SerializeField] private string _pathOfBonusGood;
        [SerializeField] private string _pathOfBonusBad;
        
        public float JumpForce;
        public float Speed;
    }
}