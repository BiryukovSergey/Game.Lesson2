using System;
using Interfeices;
using UnityEngine;

namespace Controller
{
    public sealed class PCInputHorizontal : IUserInputProxy
    {
        public event Action<float> AxisOnChange = delegate(float f) {  };
        
        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis("Horizontal"));
        }
    }
}