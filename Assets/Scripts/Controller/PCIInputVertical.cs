using System;
using Interfeices;
using UnityEngine;

namespace Controller
{
    public sealed class PCIInputVertical : IUserInputProxy
    {
        public event Action<float> AxisOnChange = delegate(float f) {  };
        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis("Vertical"));
        }
    }
}