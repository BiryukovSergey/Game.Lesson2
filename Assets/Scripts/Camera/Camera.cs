using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private float _offsetY;
    [SerializeField]
    private float _offsetX;

    private GameObject _player;
    private Camera _camera;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerMove>().gameObject;
        _camera = GetComponent<Camera>();
    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(_player.transform.position.x + _offsetX, _player.transform.position.y + _offsetY, _player.transform.position.z);
        //transform.Rotate(Vector3.up,_offsetX);
        
    }

    
}
