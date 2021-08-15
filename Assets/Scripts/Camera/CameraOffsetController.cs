using System.Reflection;
using UnityEngine;

public class CameraOffsetController : IExecute
{
    private Transform _playerTransform;
    private Camera _camera;
    private Vector3 _offset;

    public CameraOffsetController(CameraOffssetData data)
    {
        _playerTransform = data.playerTransform;
        _camera = data.Camera;
        _offset = data.Offset;
    }

    public void CameraOffset()
    {
        var position = _playerTransform.position;
        _camera.transform.position = new Vector3(position.x + _offset.x,
            position.y + _offset.y, position.z + _offset.z);
    }

    public void Update()
    {
        CameraOffset();
    }
}
