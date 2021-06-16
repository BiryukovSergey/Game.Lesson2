using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private float _offsetY;
    [SerializeField]
    private float _offsetX;

    [SerializeField] private Transform _target;
    public float Smooth = 3.0f;
    public Vector3 offset = new Vector3(0, 2, -5);

    private GameObject _player;
    private Camera _camera;
    
    

    private void Awake()
    {
       // _player = FindObjectOfType<PlayerMove>().gameObject;
       // _camera = GetComponent<Camera>();
    }
    private void FixedUpdate()
    {
       // transform.position = new Vector3(_player.transform.position.x + _offsetX, _player.transform.position.y + _offsetY, _player.transform.position.z);

       transform.position = Vector3.Lerp(transform.position, _target.position + offset, Time.deltaTime * Smooth);

    }

    
}
