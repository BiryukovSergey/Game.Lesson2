
using UnityEngine;

public class CameraOffsetView : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Vector3 _offset;
    private Camera _camera;
    private CameraOffssetData _cameraOffssetData;
    private CameraOffsetController _controller;

    private void Start()
    {
        _camera = Camera.main;
        _cameraOffssetData = new CameraOffssetData(_player, _offset,_camera);
        _controller = new CameraOffsetController(_cameraOffssetData);
    }

    private void Update()
    {
        _controller.CameraOffset();
    }
}
