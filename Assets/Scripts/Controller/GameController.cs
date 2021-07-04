using System.Collections.Generic;
using Interfeices;
using UnityEngine;
using Object = UnityEngine.Object; 

namespace Controller
{
    public class GameController : MonoBehaviour
    {
        public InteractiveObject[] _interactiveObject; 
        
        private List<IFixedUpdate> _fixedUpdatesList;
        private List<IUpdate> _updatesList;
        private List<IStart> _startsList;

        public GameController()
        {
            _fixedUpdatesList = new List<IFixedUpdate>();
            _updatesList = new List<IUpdate>();
            _startsList = new List<IStart>();
        }
        
        
        private void Awake()
        {
            _interactiveObject = Object.FindObjectsOfType<InteractiveObject>();
            new Inicialization(this);
        }

        private void Update()
        {
            for (int i = 0; i < _interactiveObject.Length; i++)
            {
                var interactiveObject = _interactiveObject[i];
                if (interactiveObject == null)
                {
                    continue;
                }

                if (interactiveObject is IBonus IBonus)
                {
                    IBonus.Bonus();
                }

                if (interactiveObject is IBadBonus IBadBonus)
                {
                    IBadBonus.BadBonus();
                }

                if (interactiveObject is IFixedUpdate IFixedUpdate)
                {
                    IFixedUpdate.FixedUpdate();
                }

                if (interactiveObject is IStart IStart)
                {
                    IStart.Start();
                }

                if (interactiveObject is IUpdate IUpdate)
                {
                    IUpdate.Update();
                }
            }
        }
    }
}