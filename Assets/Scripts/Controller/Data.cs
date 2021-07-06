using System.IO;
using UnityEngine;
using Object = System.Object;

namespace Controller
{
    [CreateAssetMenu(fileName = "Data",menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;
        [SerializeField] private string _playerEnemyPath;

        private PlayerData _player;
       // private EnemyData _enemy;


        public PlayerData Player
        {
            get
            {
                if (_player == null)
                {
                    _player = Resources.Load<PlayerData>("Data/" +_playerDataPath);
                }

                return _player;
            }
        }
/*
        public EnemyData Enemy
        {
            get
            {
                if (_enemy == null)
                {
                    _enemy = Resources.Load<EnemyData>("Data/" + _playerEnemyPath);
                }
            }
        }*/

    }
}