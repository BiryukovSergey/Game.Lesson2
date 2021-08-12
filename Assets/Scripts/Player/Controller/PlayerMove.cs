using UnityEngine;
using UnityEngine.UI;

namespace Controller
{
    public class PlayerMove
    {
        private readonly SaveDataRepository _saveDataRepository;

        private float _moveX;
        private float _moveY;
        private Vector3 _move;
        private Rigidbody _rigidbody;
        private bool _ground;
        
        private PlayerModel _playerModel;

        public float Speed;
        public float JumpForce;
        public bool inAir;

        public Text Text;

        public PlayerMove()
        {

        }

        public PlayerMove(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
            _playerModel = new PlayerModel();
            Speed = _playerModel.Speed;
            JumpForce = _playerModel.JumpForce;
        }
        internal void Move()
        {
            _moveY = Input.GetAxis("Vertical");
            _moveX = Input.GetAxis("Horizontal");
            _move = new Vector3(-_moveY, 0, _moveX);
            _rigidbody.AddForce(_move * Speed, ForceMode.Acceleration);
        }

        internal void Jump()
        {
            if (Input.GetKey(KeyCode.Space) && !inAir)
            {
                inAir = true;
                _rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Force);
            }
            
        }
    }
}