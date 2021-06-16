using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float Smooth = 3.0f;
    [SerializeField] private Vector3 offset = new Vector3(2, 5, 0);

    private GameObject _player;
    private Camera _camera;
    
    private void FixedUpdate()
    {
       transform.position = Vector3.Lerp(transform.position, _target.position + offset, Time.deltaTime * Smooth);
    }
}
