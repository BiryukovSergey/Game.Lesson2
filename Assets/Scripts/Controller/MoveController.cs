using Interfeices;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

namespace Controller
{
    public class MoveController : IExecute,ICleanup
    {
        private float _horizontal;
        private float _vertical;
        private Vector3 _move;
        private IUserInputProxy _horizontalInputProxy;
        private IUserInputProxy _verticalInputProxy;

        public MoveController((IUserInputProxy inputHorizontal, IUserInputProxy inpurVertical) input)
        {
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inpurVertical;
            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisChange;
            _verticalInputProxy.AxisOnChange += VerticalOnAxisOnChamge;
        }

        private void VerticalOnAxisOnChamge(float value)
        {
            _vertical = value;
        }

        private void HorizontalOnAxisChange(float value)
        {
            _horizontal = value;
        }

        public void Excute()
        {
            
        }

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChange -= HorizontalOnAxisChange;
            _verticalInputProxy.AxisOnChange -= VerticalOnAxisOnChamge;
        }
    }
}