using UnityEngine;

public class MiniMapData
    {
        private Transform _playerPosition; // позиция игрока
        private Vector3 _offset; // отдалеие
        private Camera _camera; // камера
        
        public MiniMapData(Transform pos, Vector3 offset,Camera camera)
        {
            _playerPosition = pos;
            _offset = offset;
            _camera = camera;
        }
        
        public Transform PlayerPosition { get => _playerPosition; }
        public Vector3 VectorCameraMiniMap { get => _offset; }
        public Camera CameraMiniMap { get => _camera; }
    }
