using Interfeices;
using UnityEngine;


namespace Controller
{
    public class PlayerController : IExecute
    {
        internal PlayerModel _playerModel;
        internal PlayerView _playerView;

        internal Vector3 move;
        internal Rigidbody rigidbody;

        internal bool ground;
        internal float resetTime;
        internal bool isResetTime;

        public PlayerController()
        {
          _playerView.playerMoving += Move;
          _playerView.playerMoving += Jump;
        }

        protected void Move()
        {
            move = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            rigidbody.AddForce(move * _playerModel.Speed, ForceMode.Acceleration);
        }
        protected void Jump()
        {
            if (Input.GetAxis("Jump") > 0 && isResetTime && ground)
            {
                rigidbody.AddForce(Vector3.up * _playerModel.JumpForce,ForceMode.Force);
            }
        }
        
        public void FixedUpdate()
        {
           _playerView.playerMoving.Invoke();
        }

        public void Execute()
        {
            
        }
    }
}