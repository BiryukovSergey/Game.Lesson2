using System;
using UnityEngine;

public class FlyView : MonoBehaviour
    {
        [SerializeField]private Transform _pos;
        private float numeric;
        private FLyPanelData _data;
        private FlyController _controller;

        private void Start()
        {
            _data = new FLyPanelData(_pos, numeric);
            _controller = new FlyController(_data);
            _controller.Range();
            FindObjectOfType<ExecuteClass>().AddInterface(_controller);
        }
    }
