﻿
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _smooth = 3.0f;
    [SerializeField] private Vector3 _offset;
    private void FixedUpdate()
    {
      transform.position = Vector3.Lerp(transform.position, _target.position + _offset, Time.deltaTime * _smooth);
    }
}
