using UnityEngine;

public class FLyPanelData
    {
        private Transform _pos;
        private float _numeric;
        public FLyPanelData(Transform transform, float number)
        {
            _pos = transform;
            _numeric = number;
        }
        
        public Transform Pos { get => _pos; }
        
        public float Numeric { get => _numeric; }
    }
