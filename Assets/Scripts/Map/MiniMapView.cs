using System;
using System.Threading;
using UnityEngine;

public class MiniMapView : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Camera _camera;
    [SerializeField] private Vector3 _vector3;
    
    private MiniMapController _mapController;
    private MiniMapData _miniMapData;
    
    private void Start()
    {
        _miniMapData = new MiniMapData(_player,_vector3, _camera);
        _mapController = new MiniMapController(_miniMapData);
        _mapController.MiniMapStart();
    }
    private void Update()
    {
        
        _mapController.MiniMapUpdate();
    }
}
