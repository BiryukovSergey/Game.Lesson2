using DefaultNamespace.Player.PlayerView;
using Interfeices;
using UnityEngine;


namespace Player.PlayerModel
{
    public class PlayerController : IFixedUpdate
    {
        internal PlayerModel _playerModel;
        internal PlayerController _playerController;
        internal PlayerView _playerView;
        
        internal Vector3 move;
        internal Rigidbody rigidbody;
        
        internal bool ground;
        internal float resetTime;
        internal bool isResetTime;

        protected void Move()
        {
            move = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            rigidbody.AddForce(move * _playerModel.speed,ForceMode.Acceleration);
        }

        protected void Jump()
        {
            if (Input.GetAxis("Jump") > 0)
            {
                if (isResetTime)
                { 
                    if (ground)
                    {
                        rigidbody.AddForce(Vector3.up * _playerModel.jumpForce,ForceMode.Force);
                    }

                }
            }
        }

        public void FixedUpdate()
        {
            _playerView.moving += Move;
            _playerView.moving += Jump;
        }
        
    }
}