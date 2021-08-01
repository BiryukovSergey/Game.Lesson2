using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controller
{
    public class BonusSpeedJump : MonoBehaviour, IBonus
    {

        internal event Action bonusDelegat = () => { };
        internal PlayerMove _player;

        internal void Awake()
        {
            _player = FindObjectOfType<PlayerMove>();
        }

        public void Bonus()
        {
            if (_player.Speed < Constants.MaxSpeed && _player.JumpForce < Constants.MaxJump)
            {
                _player.Speed += Constants.GoodBonusSpeed;
                _player.JumpForce += Constants.GoodBonusJump;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(Constants.TagPlayer))
            {
                StartCoroutine(inEnter());
            }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag(Constants.TagPlayer))
            {
                StartCoroutine(inExit());
            }

        }

        public IEnumerator inEnter()
        {
            yield return null;
            if (_player.Speed < Constants.MaxSpeed && _player.JumpForce < Constants.MaxJump)
            {
                bonusDelegat += Bonus;
                bonusDelegat.Invoke();
                Debug.Log("Ваша скорость и высота прыжка временно увеличенны!");
            }
        }

        public IEnumerator inExit()
        {
            yield return new WaitForSeconds(Constants.TimeColldawn);
            if (_player.Speed < Constants.MaxSpeed && _player.JumpForce < Constants.MaxJump)
            {
                bonusDelegat -= Bonus;
                bonusDelegat.Invoke();
                Debug.Log("Положительный бонус деактивирован!");
            }
        }

        ~BonusSpeedJump()
        {
            bonusDelegat -= Bonus;
        }
    }
}

    

