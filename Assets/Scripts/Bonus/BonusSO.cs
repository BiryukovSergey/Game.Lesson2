using System.IO;
using UnityEngine;

namespace Bonus
{
    [CreateAssetMenu (menuName = "Bonus/bonus",fileName = "BonusSO")]
    public class BonusSO : ScriptableObject
    {
        //TODO разобраться и настроить путь для SO
        
        //[SerializeField] private string _pathOfBonusGood;
       // [SerializeField] private string _pathOfBonusBad;
        
        internal float JumpForce;
        internal float Speed;
        public float jumpForce
        {
            get
            {
                return JumpForce;
            }
        }
        public float speed
        {
            get
            {
                return Speed;
            }
        }
    }
}