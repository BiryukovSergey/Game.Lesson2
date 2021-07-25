using System.IO;
using UnityEngine;


namespace Bonus
{
    [CreateAssetMenu (menuName = "Bonus/bonus/bonus",fileName = "BonusSO")]
    public class BonusSO : ScriptableObject
    {
        [Header("Jump Force")] 
        public float JumpForce;
        [Header("Speed")]
        public float Speed;
    }
}