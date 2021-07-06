using System;
using System.Data.Common;
using UnityEngine;

namespace Controller
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Data _data;
        private Controllers _controllers;

        public GameController(Controllers controllers)
        {
        }

        private void Start()
        {
            _controllers = new Controllers();
          //  new GameInitialization(_controllers, _data); <------------- дописать класс
            _controllers.Initialization();
        }

        private void Update()
        {
            _controllers.Execute();
        }

        private void LateUpdate()
        {
            _controllers.LateExecute();
        }

        private void OnDestroy()
        {
            _controllers.Cleanup();
        }
    }
}