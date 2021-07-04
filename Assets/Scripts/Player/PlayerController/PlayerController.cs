using System;
using DefaultNamespace;
using UnityEngine;


namespace Player.PlayerModel
{
    public class PlayerController : AbstractClass
    {
        internal PlayerMove _playerMove;
        internal Vector3 _move;
        internal Rigidbody _rigidbody;

        private void Awake()
        {
            PlayerMove _playerMove = new PlayerMove();
        }

        protected void Move()
        {
            _move = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            _rigidbody.AddForce(_move * _playerMove.Speed,ForceMode.Acceleration);
        }

        protected void Jump()
        {
            if (Input.GetAxis("Jump") > 0)
            {
                if (isResetTime)
                { 
                    if (ground)
                    {
                        _rigidbody.AddForce(Vector3.up * _playerMove.JumpForce,ForceMode.Force);
                    }

                }
            }
        }
    }
}