using System;
using System.Collections.Generic;
using Interfeices;
using UnityEngine;
using Object = UnityEngine.Object; 

namespace Controller
{
    public class GameController : IInitialization, IExecute, ILateExecute,ICleanup
    {
        private List<IExecute> _executeControllers;
        private List<ILateExecute> _lateControllers;
        private List<ICleanup> _cleanupControllers;
        private List<IInitialization> _initializeController;

        public GameController()
        {
            _executeControllers = new List<IExecute>();
            _lateControllers = new List<ILateExecute>();
            _cleanupControllers = new List<ICleanup>();
            _initializeController = new List<IInitialization>();
        }
        
        
        private void Awake()
        {
            new Inicialization(this);
        }
        
        internal GameController Add(IController controller)
        {
            if (controller is IInitialization inicializeController)
            {
                _initializeController.Add(inicializeController);
            }

            if (controller is IExecute executeController)
            {
                _executeControllers.Add(executeController);
            }

            if (controller is ILateExecute iLateExecuteController)
            {
                _lateControllers.Add(iLateExecuteController);
            }

            if (controller is ICleanup icleaCleanupController)
            {
                _cleanupControllers.Add(icleaCleanupController);
            }

            return this;
        }


        public void Initialization()
        {
            for (var i = 0; i < _initializeController.Count; ++i)
            {
                _initializeController[i].Initialization();
            }
        }

        public void Execute()
        {
            for (var i = 0; i < _executeControllers.Count; ++i)
            {
                _executeControllers[i].Execute();
            }
        }

        public void LateExecute()
        {
            for (var i = 0; i < _executeControllers.Count; ++i)
            {
                _lateControllers[i].LateExecute();
            }
        }

        public void Cleanup()
        {
            for (var i = 0; i < _cleanupControllers.Count; ++i)
            {
                _cleanupControllers[i].Cleanup();
            }
        }
    }
}